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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void txtBoxUser_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text != "")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.Black;
            }
        }

        private void txtBoxSenha_Enter(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = true;
            if (txtBoxSenha.Text != "") {
                txtBoxSenha.Text = "";
                txtBoxSenha.ForeColor = Color.Black;
            }
        }

        private void txtBoxUser_Leave(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                txtBoxUser.Text = "Digite seu usuário";
                txtBoxUser.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxSenha_Leave(object sender, EventArgs e)
        {
            if (txtBoxSenha.Text=="")
            {
                txtBoxSenha.UseSystemPasswordChar = false;
                txtBoxSenha.Text = "Digite sua Senha";
                txtBoxSenha.ForeColor = Color.LightGray;
            }
        }

        private void lblRecuperarSenha_Click(object sender, EventArgs e)
        {
            // TelaRecuperarSenha janela = new TelaRecuperarSenha();


           // this.Visible = false;
           // janela.Show();
        }

        //Passagem de tela:
        private void btnEntrar_Click(object sender, EventArgs e)
        {   
            string login = txtBoxUser.Text.Trim();
            string senha = txtBoxSenha.Text.Trim();

            if (login == "" || senha == "")
            {
                MessageBox.Show("Informe login e senha!");
                return;
            }

            using (var conexao = Banco.GetConnection())
            {
                try
                {
                    conexao.Open();

                    string sql = @"
                        SELECT cod_usuario, nome_usuario, cargo_usuario, nivel_usuario
                        FROM usuarios
                        WHERE login_usuario = @login
                          AND senha_usuario = @senha;";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idUsuario = reader.GetInt32("cod_usuario");
                                string nome = reader.GetString("nome_usuario");
                                string cargo = reader.GetString("cargo_usuario");
                                string nivel = reader.GetString("nivel_usuario");

                                MenuInicial menu = new MenuInicial(idUsuario);
                                menu.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Login ou senha inválidos!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStockFlow_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
// AppendFormat