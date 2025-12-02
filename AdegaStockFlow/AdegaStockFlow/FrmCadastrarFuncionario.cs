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
    public partial class FrmCadastrarFuncionario : Form
    {
        private string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;
        public FrmCadastrarFuncionario(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string login = txtLogin.Text.Trim();
            string senhaTexto = txtSenha.Text.Trim();
            string confirmar = txtConfirmarSenha.Text.Trim();
            string cargo = txtCargo.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome do funcionário.");
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Informe o login.");
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senhaTexto) || string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Informe e confirme a senha.");
                return;
            }

            if (senhaTexto != confirmar)
            {
                MessageBox.Show("A confirmação de senha não confere.");
                txtConfirmarSenha.Focus();
                return;
            }

            if (!rbFuncionario.Checked && !rbAdministrador.Checked)
            {
                MessageBox.Show("Selecione o nível de acesso.");
                return;
            }

            if (string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Informe o cargo.");
                txtCargo.Focus();
                return;
            }

            int nivelAcesso = rbFuncionario.Checked ? 1 : 2;

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sqlCheck = "SELECT COUNT(*) FROM usuarios WHERE login_usuario = @login;";

                using (var cmdCheck = new MySqlCommand(sqlCheck, conexao))
                {
                    cmdCheck.Parameters.AddWithValue("@login", login);
                    long qtd = (long)cmdCheck.ExecuteScalar();

                    if (qtd > 0)
                    {
                        MessageBox.Show("Já existe um usuário com esse login.");
                        return;
                    }
                }

                string sqlInsert = @"
            INSERT INTO usuarios
                (nome_usuario, login_usuario, senha_usuario, nivel_usuario, cargo_usuario)
            VALUES
                (@nome,       @login,        @senha,        @nivel,        @cargo);";

                using (var cmdInsert = new MySqlCommand(sqlInsert, conexao))
                {
                    cmdInsert.Parameters.AddWithValue("@nome", nome);
                    cmdInsert.Parameters.AddWithValue("@login", login);          
                    cmdInsert.Parameters.AddWithValue("@senha", senhaTexto);     
                    cmdInsert.Parameters.AddWithValue("@nivel", nivelAcesso);
                    cmdInsert.Parameters.AddWithValue("@cargo", cargo);

                    int linhas = cmdInsert.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Funcionário cadastrado com sucesso!");

                        txtNome.Clear();
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtConfirmarSenha.Clear();
                        txtCargo.Clear();
                        rbFuncionario.Checked = false;
                        rbAdministrador.Checked = false;
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro foi inserido.");
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGerenciarFuncionario gerenciar = new FrmGerenciarFuncionario(usuarioLogado);

            gerenciar.Show();
            this.Close();
        }
    }
}
