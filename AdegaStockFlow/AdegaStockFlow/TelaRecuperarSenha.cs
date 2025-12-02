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
    public partial class FrmRecuperarSenha : Form
    {
        public static string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";

        public FrmRecuperarSenha()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaLogin janela = new TelaLogin();

            janela.Show();
            this.Close();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show("Digite um ID válido.");
                return;
            }

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = "SELECT nome_usuario FROM usuarios WHERE cod_usuario = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Usuário não encontrado.");
                        return;
                    }

                    FrmNovaSenha novaSenha = new FrmNovaSenha(id);
                    novaSenha.Show();
                    this.Close();
                }
            }
        }
    }
}
