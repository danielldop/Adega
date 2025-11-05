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
    public partial class TelaRecuperarSenha : Form
    {
        public string palavrachave;

        private List<Usuario> listusuario;
        public TelaRecuperarSenha(List<Usuario>listusuario)
        {
            InitializeComponent();
            this.listusuario = listusuario;
        }

        private void TelaRecuperarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaLogin janela = new TelaLogin();

            janela.Show();
            this.Close();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            palavrachave = txtBoxBanda.Text;
            Boolean pass = false;
            foreach (var usuario in listusuario)
            {
                if (usuario.getId().ToString() == palavrachave)
                {
                    lblMostraSenha.Text = "Usuario: " + usuario.getNome() + "\nSenha: " + usuario.getSenha() + "\nCargo: " + usuario.getCargo();
                    pass = true;
                }
            }

            if (pass != true)
            {
                MessageBox.Show("ID não indentificado. Por Favor, Tente Novamente", "ERROR_404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
