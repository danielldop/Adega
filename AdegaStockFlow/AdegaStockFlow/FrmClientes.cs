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
    public partial class FrmClientes : Form
    {
        private int usuarioLogado;
        private string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        public FrmClientes(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente telaCadastro = new FrmCadastrarCliente(usuarioLogado);
            telaCadastro.Show();
            this.Close();
        }

        private void CarregarClientes(string nome, string telefone)
        {
            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = @"
            SELECT 
                cod_cliente   AS 'Código',
                nome_cliente  AS 'Nome',
                telefone_cliente AS 'Telefone',
                email_cliente AS 'Email',
                endereco_cliente AS 'Endereço',
                nasc_cliente  AS 'Data de Nascimento'
            FROM clientes
            WHERE 1 = 1";

                if (!string.IsNullOrWhiteSpace(nome))
                {
                    sql += " AND nome_cliente LIKE @nome";
                }

                if (!string.IsNullOrWhiteSpace(telefone))
                {
                    sql += " AND telefone_cliente LIKE @tel";
                }

                sql += " ORDER BY nome_cliente;";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrWhiteSpace(nome))
                        cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    if (!string.IsNullOrWhiteSpace(telefone))
                        cmd.Parameters.AddWithValue("@tel", "%" + telefone + "%");

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        da.Fill(tabela);

                        dgvClientes.DataSource = tabela;
                        dgvClientes.ReadOnly = true;
                        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtTelefone.Clear();

            CarregarClientes(null, null);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string telefone = txtTelefone.Text.Trim();

            CarregarClientes(nome, telefone);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }
    }
}
