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
    public partial class FrmCadastrarCliente : Form
    {
        private int usuarioLogado;
        string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";

        public FrmCadastrarCliente(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string telefone = mtbTelefone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string endereco = txtEndereco.Text.Trim();
            DateTime dataNasc = dtpNascimento.Value.Date;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome do cliente!");
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(telefone) || telefone.Contains("_"))
            {
                MessageBox.Show("Informe um telefone válido!");
                mtbTelefone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Informe o email!");
                txtEmail.Focus();
                return;
            }

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                try
                {
                    conexao.Open();

                    string sql = @"
                        INSERT INTO clientes
                            (nome_cliente, telefone_cliente, email_cliente, endereco_cliente, nasc_cliente)
                        VALUES
                            (@nome, @telefone, @email, @endereco, @nasc);";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@nasc", dataNasc);

                        int linhas = cmd.ExecuteNonQuery();

                        if (linhas > 0)
                        {
                            MessageBox.Show("Cliente cadastrado com sucesso!");

                            txtNome.Clear();
                            mtbTelefone.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            dtpNascimento.Value = DateTime.Today;

                            txtNome.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi inserido!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmClientes novaTela = new FrmClientes(usuarioLogado);

            novaTela.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente telaCadastrar = new FrmCadastrarCliente(usuarioLogado);

            telaCadastrar.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }
    }
}
