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
    public partial class FrmVenda : Form
    {
        public static string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;
        private decimal subtotal = 0m;
        private decimal descontoPercentual = 0m;
        private decimal total = 0m;

        public FrmVenda(int idUsuario)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.RowHeadersVisible = false;

            usuarioLogado = idUsuario;
        }


        private void FrmVenda_Load(object sender, EventArgs e)
        {
            txtDesconto.Enabled = false;
            txtDesconto.Text = "5% automático";

            timer1.Start();

            ConfigurarGrid();
            CarregarClientes();
            CarregarProdutos();
            AtualizarTotais();
        }

        private void ConfigurarGrid()
        {
            dgvCarrinho.AutoGenerateColumns = false;
            dgvCarrinho.Columns.Clear();

            dgvCarrinho.Columns.Add("Codigo", "Código");
            dgvCarrinho.Columns["Codigo"].Width = 60;

            dgvCarrinho.Columns.Add("Produto", "Produto");
            dgvCarrinho.Columns["Produto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCarrinho.Columns.Add("Quantidade", "Quantidade");
            dgvCarrinho.Columns["Quantidade"].Width = 80;

            dgvCarrinho.Columns.Add("Preco", "Preço");
            dgvCarrinho.Columns["Preco"].Width = 80;

            dgvCarrinho.Columns.Add("TotalLinha", "Total");
            dgvCarrinho.Columns["TotalLinha"].Width = 90;

            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void CarregarClientes()
        {
            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = "SELECT cod_cliente, nome_cliente FROM clientes ORDER BY nome_cliente;";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    da.Fill(tabela);

                    cmbCliente.DataSource = null;
                    cmbCliente.Items.Clear();

                    cmbCliente.DisplayMember = "nome_cliente";  
                    cmbCliente.ValueMember = "cod_cliente";   
                    cmbCliente.DataSource = tabela;
                }
            }

            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.SelectedIndex = -1;
        }

        private void CarregarProdutos()
        {
            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                string sql = "SELECT cod_produto, nome_produto FROM produtos WHERE ativo = 1 ORDER BY nome_produto";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    da.Fill(tabela);

                    cmbProduto.DataSource = tabela;
                    cmbProduto.DisplayMember = "nome_produto";
                    cmbProduto.ValueMember = "cod_produto";
                    cmbProduto.SelectedIndex = -1;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldata.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente primeiro.");
                return;
            }

            int codCliente = Convert.ToInt32(cmbCliente.SelectedValue);

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = "SELECT endereco_cliente FROM clientes WHERE cod_cliente = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", codCliente);

                    object result = cmd.ExecuteScalar();
                    lblEndereco.Text = result != null && result != DBNull.Value
                        ? result.ToString()
                        : "Endereço não cadastrado";
                }
            }

            AtualizarTotais();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text.Trim(), out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida (somente números e maior que zero).");
                txtQuantidade.Focus();
                return;
            }

            int codProduto = Convert.ToInt32(cmbProduto.SelectedValue);
            string nomeProduto;
            decimal preco;
            int estoqueAtual;

            using (var conn = new MySqlConnection(stringDeConexao))
            {
                conn.Open();
                string sql = "SELECT nome_produto, valorVenda_produto, qtd_produto FROM produtos WHERE cod_produto = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", codProduto);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Erro: produto não encontrado no banco.");
                            return;
                        }

                        nomeProduto = reader.GetString("nome_produto");
                        preco = reader.GetDecimal("valorVenda_produto");
                        estoqueAtual = reader.GetInt32("qtd_produto");
                    }
                }
            }

            if (quantidade > estoqueAtual)
            {
                MessageBox.Show($"Estoque insuficiente!\n\nEstoque atual: {estoqueAtual} unidades.");
                return;
            }

            decimal totalLinha = preco * quantidade;

            dgvCarrinho.Rows.Add(codProduto, nomeProduto, quantidade, preco.ToString("N2"), totalLinha.ToString("N2"));

            subtotal += totalLinha;
            AtualizarTotais();

            txtQuantidade.Clear();
            cmbProduto.SelectedIndex = -1;
        }

        private void AtualizarTotais()
        {
            subtotal = 0m;

            foreach (DataGridViewRow row in dgvCarrinho.Rows)
            {
                if (row.IsNewRow) continue;
                decimal totalLinha = decimal.Parse(row.Cells["TotalLinha"].Value.ToString());
                subtotal += totalLinha;
            }

            descontoPercentual = (cmbCliente.SelectedIndex != -1) ? 5m : 0m;

            decimal valorDesconto = subtotal * (descontoPercentual / 100m);
            total = subtotal - valorDesconto;

            lblSubtotal.Text = "Subtotal:  R$ " + subtotal.ToString("N2");
            lblTotal.Text = $"Total:  R$ {total:N2}  (Desconto: {descontoPercentual}%)";
        }


        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

        private void btnfinalizarvenda_Click(object sender, EventArgs e)
        {
            if (dgvCarrinho.Rows.Count == 0)
            {
                MessageBox.Show("Adicione produtos à venda antes de finalizar.");
                return;
            }

            int? codCliente = null;
            if (cmbCliente.SelectedIndex != -1)
                codCliente = Convert.ToInt32(cmbCliente.SelectedValue);

            // Abre a tela de pagamento passando as infos necessárias
            using (var tela = new TelaPagamento(dgvCarrinho, subtotal, descontoPercentual, total, usuarioLogado, codCliente))
            {
                var result = tela.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Venda foi concluída na tela de pagamento
                    dgvCarrinho.Rows.Clear();
                    subtotal = 0m;
                    descontoPercentual = 0m;
                    total = 0m;
                    AtualizarTotais();
                }
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
            {
                lblEndereco.Text = "";
                AtualizarTotais(); 
                return;
            }

            int codCliente = Convert.ToInt32(cmbCliente.SelectedValue);

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = "SELECT endereco_cliente FROM clientes WHERE cod_cliente = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", codCliente);

                    object result = cmd.ExecuteScalar();
                    lblEndereco.Text = result != null && result != DBNull.Value
                        ? result.ToString()
                        : "Endereço não cadastrado";
                }
            }

            AtualizarTotais();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);

            menu.Show();
            this.Close();
        }
    }
}
