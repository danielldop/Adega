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
using MySql.Data.MySqlClient;

namespace AdegaStockFlow
{
    public partial class FrmGerenciarProdutos : Form
    {

        private string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;"; //colocar senha pwd=ifsp; se for no pc do instituto
        private int usuarioLogado;


        public FrmGerenciarProdutos(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            FrmEditarProdutos TelaEditar = new FrmEditarProdutos(usuarioLogado);
            TelaEditar.Show();
            this.Hide();

        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            FrmGerenciarProdutos TelaAdd = new FrmGerenciarProdutos(usuarioLogado);
            TelaAdd.Show();
            this.Hide();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            FrmExcluirProduto TelaExcluir = new FrmExcluirProduto(usuarioLogado);
            TelaExcluir.Show();
            this.Hide();
        }

        private void btnVisualizarEstoque_Click(object sender, EventArgs e)
        {
            FrmConsultaEstoque TelaEstoque = new FrmConsultaEstoque(usuarioLogado);
            TelaEstoque.Show();
            this.Hide();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                MessageBox.Show("Informe o nome do produto!");
                txtNomeProduto.Focus();
                return;
            }
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria!");
                cmbCategoria.DroppedDown = true;
                return;
            }
            if (!int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Informe uma quantidade válida! (ex: 10)");
                txtQuantidade.Focus();
                return;
            }
            
                
            if(!decimal.TryParse(txtValorCompra.Text, NumberStyles.Number, new CultureInfo("pt-br"), out decimal valorCompra))
            {
                MessageBox.Show("Informe um valor de compra válido! (ex: 15,90)");
                txtValorCompra.Focus();
                return;
            }
            if(!decimal.TryParse(txtValorVenda.Text, NumberStyles.Number, new CultureInfo("pt-br"), out decimal valorVenda))
            {
                MessageBox.Show("Informe um valor de venda válido! (ex: 15,90)");
                txtValorVenda.Focus();
                return;
            }

            string nome = txtNomeProduto.Text.Trim();
            string descricao = txtDescricao.Text.Trim();
            string categoria = cmbCategoria.SelectedItem.ToString();

            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                try
                {
                    conexao.Open();

                    string sql = @" 
                        INSERT INTO produtos
                        (nome_produto, desc_produto, cat_produto, valorCompra_produto, valorVenda_produto, qtd_produto)
                        VALUES
                        (@nome, @desc, @cat, @valorCompra, @valorVenda, @qtd);";

                        MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@desc", descricao);
                    cmd.Parameters.AddWithValue("@cat", categoria);
                    cmd.Parameters.AddWithValue("@valorCompra", valorCompra);
                    cmd.Parameters.AddWithValue("@valorVenda", valorVenda);
                    cmd.Parameters.AddWithValue("@qtd", quantidade);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!");

                        txtNomeProduto.Clear();
                        txtDescricao.Clear();
                        txtValorCompra.Clear();
                        txtValorVenda.Clear();
                        txtQuantidade.Clear();
                        cmbCategoria.SelectedIndex = -1;
                        txtNomeProduto.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro foi inserido!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
                }
                
            }
        }

        private void FrmGerenciarProdutos_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Alcoólico");
            cmbCategoria.Items.Add("Sem Álcool");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }
    }
}
