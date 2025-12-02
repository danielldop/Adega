using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdegaStockFlow
{
    public partial class FrmNovaSenha : Form
    {
        public static string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioId;
        public FrmNovaSenha(int id)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            usuarioId = id;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text.Trim();
            string confirmar = txtConfirmarSenha.Text.Trim();

            if (string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Preencha os dois campos de senha.");
                return;
            }

            if (novaSenha != confirmar)
            {
                MessageBox.Show("As senhas não conferem.");
                txtConfirmarSenha.Focus();
                return;
            }

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = "UPDATE usuarios SET senha_usuario = @senha WHERE cod_usuario = @id;";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@senha", novaSenha); 
                    cmd.Parameters.AddWithValue("@id", usuarioId);    

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Senha atualizada com sucesso!");

                        TelaLogin login = new TelaLogin();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma senha foi alterada. Verifique o usuário.");
                    }
                }
            }
        }
    }
    
}
