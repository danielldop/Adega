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
    public partial class FrmEditarProdutos : Form
    {
        private string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;
        public FrmEditarProdutos(int idUsuario)
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

        private void FrmEditarProdutos_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQtdEntrada.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            if (!int.TryParse(txtQtdEntrada.Text.Trim(), out int qtdEntrada) || qtdEntrada <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida (maior que zero).");
                txtQtdEntrada.Focus();
                return;
            }

            if (!decimal.TryParse(txtValorCompra.Text.Trim(), NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valorCompra))
            {
                MessageBox.Show("Informe um valor de compra válido (ex: 10,50).");
                txtValorCompra.Focus();
                return;
            }

            if (!decimal.TryParse(txtValorVenda.Text.Trim(), NumberStyles.Number, new CultureInfo("pt-BR"), out decimal valorVenda))
            {
                MessageBox.Show("Informe um valor de venda válido (ex: 15,90).");
                txtValorVenda.Focus();
                return;
            }

            int codProduto = Convert.ToInt32(cmbProduto.SelectedValue);

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                try
                {
                    conexao.Open();

                    string sql = @"
                UPDATE produtos
                SET qtd_produto = qtd_produto + @qtdEntrada,
                    valorCompra_produto = @valorCompra,
                    valorVenda_produto = @valorVenda
                WHERE cod_produto = @id;";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@qtdEntrada", qtdEntrada);
                        cmd.Parameters.AddWithValue("@valorCompra", valorCompra);
                        cmd.Parameters.AddWithValue("@valorVenda", valorVenda);
                        cmd.Parameters.AddWithValue("@id", codProduto);

                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                        {
                            MessageBox.Show("Produto atualizado com sucesso!");
                            txtQtdEntrada.Clear();
                            txtValorCompra.Clear();
                            txtValorVenda.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum produto encontrado para atualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
                }
            }
        }
    }
}
