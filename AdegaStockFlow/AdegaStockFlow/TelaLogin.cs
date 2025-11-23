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
    public partial class TelaLogin : Form
    {
        List<Usuario> listusuario = new List<Usuario>();
        List<Produto> listproduto = new List<Produto>();

        public TelaLogin()
        {
            InitializeComponent();

            

            listusuario.Add(new Usuario().CadastrarUsuario(111,"Jeff","123",2));
            listusuario.Add(new Usuario().CadastrarUsuario(222, "Fabio", "456", 1));
            listusuario.Add(new Usuario().CadastrarUsuario(333, "Marley", "789", 1));

            listproduto.Add(new Produto().CadastrarProduto(1, "Coca Cola","350ml", "Bebida", "Gaseificada", 48, "30/12/2026",8.5,10.5));
            listproduto.Add(new Produto().CadastrarProduto(2, "Jack Deniels","1L","Bebida", "Alcool",24,"N/A", 120.20,140.99));
            listproduto.Add(new Produto().CadastrarProduto(3, "Agua", "300ml","Bebida","Natural",36, "05/10/2026",2.5,4.5));

            lblStockFlow.Parent = this;
            lblStockFlow.BackColor = Color.Transparent;




            txtBoxSenha.UseSystemPasswordChar = false;
            txtBoxUser.Text = "Digite seu usuário";
            txtBoxSenha.Text = "Digite sua senha";

            txtBoxUser.ForeColor = Color.LightGray;
            txtBoxSenha.ForeColor = Color.LightGray;
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
            TelaRecuperarSenha janela = new TelaRecuperarSenha(listusuario);


            this.Visible = false;
            janela.Show();
        }

        //Passagem de tela:
        private void btnEntrar_Click(object sender, EventArgs e)
        {   
            foreach (var usuario in listusuario) { 

                if (txtBoxUser.Text == usuario.getNome())
                {
                    if ((txtBoxSenha.Text == usuario.getSenha()) && (txtBoxUser.Text == usuario.getNome()))
                    {
                        int id = usuario.getId();
                        MenuInicial janela = new MenuInicial(listusuario, listproduto, id);

                        janela.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Senha Inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
// AppendFormat