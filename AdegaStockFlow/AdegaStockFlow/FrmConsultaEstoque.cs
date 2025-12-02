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
    public partial class FrmConsultaEstoque : Form
    {
        private string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;"; //colocar senha pwd=ifsp; se for no pc do instituto
        private int usuarioLogado;

        public FrmConsultaEstoque(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void CarregarProdutos()
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                try
                {
                    conexao.Open();

                    string sql = @"
                        SELECT
                            cod_produto,
                            nome_produto,
                            desc_produto,
                            cat_produto,
                            valorVenda_produto,
                            valorCompra_produto,
                            qtd_produto
                        FROM produtos";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable tabela = new DataTable();
                    da.Fill(tabela);

                    dgvEstoque.DataSource = tabela;
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
                }
            }
        }

        private void FrmConsultaEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos();

            cmbCategoria.Items.Add("Todos");
            cmbCategoria.Items.Add("Alcoólico");
            cmbCategoria.Items.Add("Sem álcool");
            cmbCategoria.SelectedIndex = 0; 

            CarregarEstoque(null, null);
        }

        private void CarregarEstoque(string categoria, string nomeParcial)
        {
            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = @"
            SELECT 
                cod_produto          AS 'Código',
                nome_produto         AS 'Produto',
                cat_produto          AS 'Categoria',
                qtd_produto          AS 'Quantidade',
                valorCompra_produto  AS 'Valor de compra',
                valorVenda_produto   AS 'Valor de venda'
            FROM produtos
            WHERE 1 = 1";

                if (!string.IsNullOrEmpty(categoria) && categoria != "Todos")
                {
                    sql += " AND cat_produto = @cat";
                }
                if (!string.IsNullOrWhiteSpace(nomeParcial))
                {
                    sql += " AND nome_produto LIKE @nome";
                }

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(categoria) && categoria != "Todos")
                        cmd.Parameters.AddWithValue("@cat", categoria);

                    if (!string.IsNullOrWhiteSpace(nomeParcial))
                        cmd.Parameters.AddWithValue("@nome", "%" + nomeParcial + "%");

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        da.Fill(tabela);

                        dgvEstoque.DataSource = tabela;
                        dgvEstoque.ReadOnly = true;
                        dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string nomeParcial = txtProduto.Text.Trim();

            CarregarEstoque(categoria, nomeParcial);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }
    }
}
