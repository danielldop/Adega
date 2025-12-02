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
        private string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";

        public TelaLogin()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void txtBoxUser_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text != "")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.Black;
            }
        }

        private void txtBoxSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            if (txtSenha.Text != "") {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtBoxUser_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Digite seu usuário";
                txtLogin.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text=="")
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Text = "Digite sua Senha";
                txtSenha.ForeColor = Color.LightGray;
            }
        }

        private void lblRecuperarSenha_Click(object sender, EventArgs e)
        {
            FrmRecuperarSenha recuperar = new FrmRecuperarSenha();

            recuperar.Show();
            this.Hide();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
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

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = @"
            SELECT 
                cod_usuario,
                nome_usuario,
                nivel_usuario,
                cargo_usuario
            FROM usuarios
            WHERE login_usuario = @login
              AND senha_usuario = @senha;";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@login", login);  
                    cmd.Parameters.AddWithValue("@senha", senha);  

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Usuário não encontrado ou senha incorreta.");
                            return;
                        }

                        int codUsuario = reader.GetInt32(reader.GetOrdinal("cod_usuario"));
                        string nome = reader.GetString(reader.GetOrdinal("nome_usuario"));
                        int nivel = reader.GetInt32(reader.GetOrdinal("nivel_usuario"));
                        string cargo = reader.GetString(reader.GetOrdinal("cargo_usuario"));

                        MenuInicial menu = new MenuInicial(codUsuario);
                        menu.Show();
                        this.Hide();
                    }
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
