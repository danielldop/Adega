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
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente telaCadastro = new FrmCadastrarCliente(usuarioLogado);
            telaCadastro.Show();
            this.Close();
        }
    }
}
