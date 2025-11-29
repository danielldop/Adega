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
    public partial class FrmExcluirProduto : Form
    {
        public static string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;
        public FrmExcluirProduto(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            FrmGerenciarProdutos TelaAdd = new FrmGerenciarProdutos(usuarioLogado);
            TelaAdd.Show();
            this.Close();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            FrmEditarProdutos TelaEditar = new FrmEditarProdutos(usuarioLogado);
            TelaEditar.Show();
            this.Close();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            FrmExcluirProduto TelaExcluir = new FrmExcluirProduto(usuarioLogado);
            TelaExcluir.Show();
            this.Close();
        }

        private void btnVisualizarEstoque_Click(object sender, EventArgs e)
        {
            FrmConsultaEstoque TelaEstoque = new FrmConsultaEstoque(usuarioLogado);
            TelaEstoque.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }

        private void CarregarProdutos()
        {
            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                try
                {
                    conexao.Open();

                    string sql = "SELECT cod_produto, nome_produto FROM produtos ORDER BY nome_produto;";

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
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
                }
            }
        }

        private void FrmExcluirProduto_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            
            if (!int.TryParse(txtLogin.Text.Trim(), out int login))
            {
                MessageBox.Show("Informe um login numérico válido.");
                txtLogin.Focus();
                return;
            }

            if (!int.TryParse(txtSenha.Text.Trim(), out int senha))
            {
                MessageBox.Show("Informe uma senha numérica válida.");
                txtSenha.Focus();
                return;
            }

            int codProduto = Convert.ToInt32(cmbProduto.SelectedValue);

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                try
                {
                    conexao.Open();

                    
                    string sqlUser = @"
                SELECT cod_usuario, nivel_usuario
                FROM usuarios
                WHERE login_usuario = @login
                  AND senha_usuario = @senha;";

                    using (var cmdUser = new MySqlCommand(sqlUser, conexao))
                    {
                        cmdUser.Parameters.AddWithValue("@login", login);
                        cmdUser.Parameters.AddWithValue("@senha", senha);

                        using (var reader = cmdUser.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Login ou senha inválidos.");
                                return;
                            }
                        }
                    }

                    
                    var result = MessageBox.Show(
                        "Tem certeza que deseja excluir este produto?",
                        "Confirmar exclusão",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                        return;

                    
                    string sqlDelete = "DELETE FROM produtos WHERE cod_produto = @id;";

                    using (var cmdDel = new MySqlCommand(sqlDelete, conexao))
                    {
                        cmdDel.Parameters.AddWithValue("@id", codProduto);

                        int linhas = cmdDel.ExecuteNonQuery();

                        if (linhas > 0)
                        {
                            MessageBox.Show("Produto excluído com sucesso!");

                            txtLogin.Clear();
                            txtSenha.Clear();

                            CarregarProdutos();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum produto foi excluído. Verifique se ele ainda existe.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir produto: " + ex.Message);
                }
            }
        }
    }
}
