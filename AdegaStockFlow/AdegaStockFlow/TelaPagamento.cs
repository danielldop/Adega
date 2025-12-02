using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdegaStockFlow
{
    public partial class TelaPagamento : Form
    {
        public static string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;

        private DataGridView carrinhoOrigem;
        private decimal subtotal;
        private decimal descontoPercentual;
        private decimal total;
        private int? codCliente;

        public TelaPagamento(DataGridView carrinho, decimal subtotal, decimal descontoPercentual, decimal total, int usuarioLogado, int? codCliente)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            this.carrinhoOrigem = carrinho;
            this.subtotal = subtotal;
            this.descontoPercentual = descontoPercentual;
            this.total = total;
            this.usuarioLogado = usuarioLogado;
            this.codCliente = codCliente;
        }

        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TelaPagamento_Load(object sender, EventArgs e)
        {
            dgvProdutos.Columns.Clear();
            dgvProdutos.AutoGenerateColumns = false;

            dgvProdutos.Columns.Add("Codigo", "Código");
            dgvProdutos.Columns["Codigo"].Width = 60;

            dgvProdutos.Columns.Add("Produto", "Produto");
            dgvProdutos.Columns["Produto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvProdutos.Columns.Add("Quantidade", "Quantidade");
            dgvProdutos.Columns["Quantidade"].Width = 80;

            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow row in carrinhoOrigem.Rows)
            {
                if (row.IsNewRow) continue;

                object cod = row.Cells["Codigo"].Value;
                object nome = row.Cells["Produto"].Value;
                object qtd = row.Cells["Quantidade"].Value;

                dgvProdutos.Rows.Add(cod, nome, qtd);
            }

            cmbFormaPagamento.Items.Clear();
            cmbFormaPagamento.Items.Add(new FormaPagamentoItem { Display = "Dinheiro", Codigo = "DINHEIRO" });
            cmbFormaPagamento.Items.Add(new FormaPagamentoItem { Display = "Pix", Codigo = "PIX" });
            cmbFormaPagamento.Items.Add(new FormaPagamentoItem { Display = "Crédito - Visa", Codigo = "VISA_CREDITO" });
            cmbFormaPagamento.Items.Add(new FormaPagamentoItem { Display = "Crédito - Master", Codigo = "MASTER_CREDITO" });
            cmbFormaPagamento.Items.Add(new FormaPagamentoItem { Display = "Débito - Visa", Codigo = "VISA_DEBITO" });
            cmbFormaPagamento.Items.Add(new FormaPagamentoItem { Display = "Débito - Master", Codigo = "MASTER_DEBITO" });

            cmbFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPagamento.SelectedIndex = 0;

            txtSubtotal.Text = subtotal.ToString("N2");
            txtDesconto.Text = descontoPercentual.ToString("N2") + " %";
            txtTotal.Text = total.ToString("N2");
            txtTroco.Text = "0,00";

            AtualizarCampoValorRecebidoEPeriodo();
        }

        private void AtualizarCampoValorRecebidoEPeriodo()
        {
            var item = (FormaPagamentoItem)cmbFormaPagamento.SelectedItem;

            if (item == null) return;

            if (item.Codigo == "DINHEIRO")
            {
                txtValorRecebido.ReadOnly = false;
                txtValorRecebido.Text = "";
                txtTroco.Text = "0,00";
            }
            else
            {
                txtValorRecebido.ReadOnly = true;
                txtValorRecebido.Text = total.ToString("N2");
                txtTroco.Text = "0,00";
            }
        }


        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            var item = (FormaPagamentoItem)cmbFormaPagamento.SelectedItem;
            if (item == null) return;

 
            if (item.Codigo != "DINHEIRO")
            {
                txtTroco.Text = "0,00";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValorRecebido.Text))
            {
                txtTroco.Text = "0,00";
                return;
            }

            if (decimal.TryParse(txtValorRecebido.Text.Replace("R$", "").Trim(),
                                 NumberStyles.Number,
                                 new CultureInfo("pt-BR"),
                                 out decimal recebido))
            {
                decimal troco = recebido - total;
                txtTroco.Text = troco < 0 ? "0,00" : troco.ToString("N2");
            }
            else
            {
                txtTroco.Text = "0,00";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cmbFormaPagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a forma de pagamento.");
                return;
            }

            var formaItem = (FormaPagamentoItem)cmbFormaPagamento.SelectedItem;
            string formaPagamentoCodigo = formaItem.Codigo;    
            string formaPagamentoDisplay = formaItem.Display;  

            decimal recebido = 0m;

            if (formaPagamentoCodigo == "DINHEIRO")
            {
                if (!decimal.TryParse(txtValorRecebido.Text.Replace("R$", "").Trim(),
                                      NumberStyles.Number,
                                      new CultureInfo("pt-BR"),
                                      out recebido))
                {
                    MessageBox.Show("Informe um valor recebido válido.");
                    txtValorRecebido.Focus();
                    return;
                }

                if (recebido < total)
                {
                    MessageBox.Show("Valor recebido é menor que o total.");
                    txtValorRecebido.Focus();
                    return;
                }
            }
            else
            {
                recebido = total;
            }

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                var trans = conexao.BeginTransaction();

                try
                {
                    string sqlVenda = @"
                INSERT INTO vendas (cod_usuario, cod_cliente, forma_pagamento, valor_venda, qtd_produto)
                VALUES (@user, @cliente, @forma, @valor, @qtdTotal);
                SELECT LAST_INSERT_ID();";

                    int qtdTotal = 0;
                    foreach (DataGridViewRow row in dgvProdutos.Rows)
                    {
                        if (row.IsNewRow) continue;
                        qtdTotal += Convert.ToInt32(row.Cells["Quantidade"].Value);
                    }

                    int codVenda;
                    using (var cmdVenda = new MySqlCommand(sqlVenda, conexao, trans))
                    {
                        cmdVenda.Parameters.AddWithValue("@user", usuarioLogado);

                        if (codCliente.HasValue)
                            cmdVenda.Parameters.AddWithValue("@cliente", codCliente.Value);
                        else
                            cmdVenda.Parameters.AddWithValue("@cliente", DBNull.Value);

                        cmdVenda.Parameters.AddWithValue("@forma", formaPagamentoCodigo); // GRAVA CÓDIGO PADRÃO
                        cmdVenda.Parameters.AddWithValue("@valor", total);
                        cmdVenda.Parameters.AddWithValue("@qtdTotal", qtdTotal);

                        codVenda = Convert.ToInt32(cmdVenda.ExecuteScalar());
                    }

                    foreach (DataGridViewRow row in dgvProdutos.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int codProd = Convert.ToInt32(row.Cells["Codigo"].Value);
                        int qtd = Convert.ToInt32(row.Cells["Quantidade"].Value);

                        string sqlUpdateEstoque = @"
                    UPDATE produtos
                    SET qtd_produto = qtd_produto - @qtd
                    WHERE cod_produto = @id;";

                        using (var cmdEst = new MySqlCommand(sqlUpdateEstoque, conexao, trans))
                        {
                            cmdEst.Parameters.AddWithValue("@qtd", qtd);
                            cmdEst.Parameters.AddWithValue("@id", codProd);
                            cmdEst.ExecuteNonQuery();
                        }

                        decimal valorCompra = 0m;
                        decimal valorVenda = 0m;

                        string sqlValores = "SELECT valorCompra_produto, valorVenda_produto FROM produtos WHERE cod_produto = @id;";

                        using (var cmdVals = new MySqlCommand(sqlValores, conexao, trans))
                        {
                            cmdVals.Parameters.AddWithValue("@id", codProd);
                            using (var reader = cmdVals.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    valorCompra = reader.GetDecimal("valorCompra_produto");
                                    valorVenda = reader.GetDecimal("valorVenda_produto");
                                }
                            }
                        }

                        string sqlHist = @"
                    INSERT INTO Historico_vendas
                        (cod_produto, cod_usuario, qtd_produto,
                         valorCompra_produto, valorVenda_produto,
                         tipo, operacao)
                    VALUES
                        (@codProd, @codUser, @qtd,
                         @vCompra, @vVenda,
                         @tipo, @operacao);";

                        using (var cmdHist = new MySqlCommand(sqlHist, conexao, trans))
                        {
                            cmdHist.Parameters.AddWithValue("@codProd", codProd);
                            cmdHist.Parameters.AddWithValue("@codUser", usuarioLogado);
                            cmdHist.Parameters.AddWithValue("@qtd", qtd);
                            cmdHist.Parameters.AddWithValue("@vCompra", valorCompra);
                            cmdHist.Parameters.AddWithValue("@vVenda", valorVenda);
                            cmdHist.Parameters.AddWithValue("@tipo", "venda");
                            cmdHist.Parameters.AddWithValue("@operacao", "venda " + codVenda);
                            cmdHist.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();

                    MessageBox.Show(
                        $"Pagamento confirmado!\n\n" +
                        $"Forma: {formaPagamentoDisplay}\n" +
                        $"Total: R$ {total:N2}");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Erro ao finalizar pagamento: " + ex.Message);
                }
            }
        }
        private class FormaPagamentoItem
        {
            public string Display { get; set; } 
            public string Codigo { get; set; } 

            public override string ToString()
            {
                return Display;
            }
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarCampoValorRecebidoEPeriodo();
        }
    }
}
