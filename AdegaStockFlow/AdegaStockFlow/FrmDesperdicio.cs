using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AdegaStockFlow
{
    public partial class FrmDesperdicio : Form
    {
        string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;
        public FrmDesperdicio(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmDesperdicio_Load(object sender, EventArgs e)
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text.Trim(), out int qtdDesperdicio) || qtdDesperdicio <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida de desperdício (maior que zero).");
                txtQuantidade.Focus();
                return;
            }

            string descricao = txtDescricao.Text.Trim();

            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Informe o login.");
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Informe a senha.");
                txtSenha.Focus();
                return;
            }

            int codProduto = Convert.ToInt32(cmbProduto.SelectedValue);

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();
                MySqlTransaction trans = conexao.BeginTransaction();

                try
                {
                    int codUsuario;
                    string nomeUsuario;

                    string sqlUser = @"
                SELECT cod_usuario, nome_usuario
                FROM usuarios
                WHERE login_usuario = @login
                  AND senha_usuario = @senha;";

                    using (var cmdUser = new MySqlCommand(sqlUser, conexao, trans))
                    {
                        cmdUser.Parameters.AddWithValue("@login", login);
                        cmdUser.Parameters.AddWithValue("@senha", senha);

                        using (var reader = cmdUser.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Login ou senha inválidos.");
                                reader.Close();
                                trans.Rollback();
                                return;
                            }

                            codUsuario = reader.GetInt32("cod_usuario");
                            nomeUsuario = reader.GetString("nome_usuario");
                        }
                    }

                    
                    string nomeProduto;
                    int estoqueAtual;
                    decimal valorCompra;
                    decimal valorVenda;

                    string sqlProd = @"
                SELECT nome_produto, qtd_produto, valorCompra_produto, valorVenda_produto
                FROM produtos
                WHERE cod_produto = @id;";

                    using (var cmdProd = new MySqlCommand(sqlProd, conexao, trans))
                    {
                        cmdProd.Parameters.AddWithValue("@id", codProduto);

                        using (var reader = cmdProd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Produto não encontrado.");
                                reader.Close();
                                trans.Rollback();
                                return;
                            }

                            nomeProduto = reader.GetString("nome_produto");
                            estoqueAtual = reader.GetInt32("qtd_produto");
                            valorCompra = reader.GetDecimal("valorCompra_produto");
                            valorVenda = reader.GetDecimal("valorVenda_produto");
                        }
                    }

                    if (qtdDesperdicio > estoqueAtual)
                    {
                        MessageBox.Show("Quantidade de desperdício maior que o estoque atual.");
                        trans.Rollback();
                        return;
                    }

                    
                    int novoEstoque = estoqueAtual - qtdDesperdicio;

                    string msg =
                        "Você está registrando desperdício:\n\n" +
                        $"Produto: {nomeProduto}\n" +
                        $"Quantidade a desperdiçar: {qtdDesperdicio}\n" +
                        $"Estoque atual: {estoqueAtual}\n" +
                        $"Estoque depois: {novoEstoque}\n\n" +
                        "Deseja confirmar?";

                    var resposta = MessageBox.Show(msg, "Confirmar desperdício",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

                    if (resposta == DialogResult.No)
                    {
                        trans.Rollback();
                        return;
                    }

                    
                    string sqlUpdate = @"
                UPDATE produtos
                SET qtd_produto = qtd_produto - @qtd
                WHERE cod_produto = @id;";

                    using (var cmdUpd = new MySqlCommand(sqlUpdate, conexao, trans))
                    {
                        cmdUpd.Parameters.AddWithValue("@qtd", qtdDesperdicio);
                        cmdUpd.Parameters.AddWithValue("@id", codProduto);
                        cmdUpd.ExecuteNonQuery();
                    }


                    string sqlDesperdicio = @"
    INSERT INTO historico_desperdicio
        (cod_produto, cod_usuario, quantidade, motivo, valor_compra, valor_venda)
    VALUES
        (@codProd, @codUser, @qtd, @motivo, @vCompra, @vVenda);";

                    using (var cmdHist = new MySqlCommand(sqlDesperdicio, conexao, trans))
                    {
                        cmdHist.Parameters.AddWithValue("@codProd", codProduto);
                        cmdHist.Parameters.AddWithValue("@codUser", codUsuario);
                        cmdHist.Parameters.AddWithValue("@qtd", qtdDesperdicio);
                        cmdHist.Parameters.AddWithValue("@motivo",
                            string.IsNullOrWhiteSpace(descricao) ? "Sem descrição" : descricao);
                        cmdHist.Parameters.AddWithValue("@vCompra", valorCompra);
                        cmdHist.Parameters.AddWithValue("@vVenda", valorVenda);

                        cmdHist.ExecuteNonQuery();
                    }

                    trans.Commit();

                 
                    MessageBox.Show(
                        "Desperdício registrado com sucesso!\n\n" +
                        $"Produto: {nomeProduto}\n" +
                        $"Quantidade: {qtdDesperdicio}\n" +
                        $"Novo estoque: {novoEstoque}",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    cmbProduto.SelectedIndex = -1;
                    txtQuantidade.Clear();
                    txtDescricao.Clear();
                    txtLogin.Clear();
                    txtSenha.Clear();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Erro ao registrar desperdício: " + ex.Message);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }
    }
}
