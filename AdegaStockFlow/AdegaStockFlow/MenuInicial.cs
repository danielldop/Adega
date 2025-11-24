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
    public partial class MenuInicial : Form
    {
        int acesso;
        private List<Usuario> listusuario;
        private List<Produto> listproduto;
        int id;
        public MenuInicial(List<Usuario> listusuario,List<Produto> listproduto, int id)
        {
            InitializeComponent();
            this.listusuario = listusuario;
            this.listproduto = listproduto;
            this.id = id;

            
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            TelaLogin  txtCargo = new TelaLogin();

            foreach (var usuario in listusuario){
                if (id == usuario.getId()) {
                    acesso = usuario.getNvacesso();
                }
            }
            if(acesso == 1)
            {
                this.Controls.Remove(btnControleDesperdicio); 
                btnControleDesperdicio.Dispose();

                this.Controls.Remove(btnHistoricoDesperdicio); 
                btnHistoricoDesperdicio.Dispose();

                this.Controls.Remove(btnGerenciarFuncionario); 
                btnGerenciarFuncionario.Dispose();

                foreach (var usuario in listusuario)
                {
                    if (id == usuario.getId()) {
                        lblCargo.Text = usuario.getCargo();
                        lblNome.Text = usuario.getNome();
                        lblId.Text = usuario.getId().ToString();

                    }
                }
                

                btnSair.Size = new System.Drawing.Size(376,46);
                btnSair.Location = new System.Drawing.Point(152,385);
            }
            else if(acesso == 2)
            {
                foreach (var usuario in listusuario)
                {
                    if (id == usuario.getId())
                    {
                        lblCargo.Text = usuario.getCargo();
                        lblNome.Text = usuario.getNome();
                        lblId.Text = usuario.getId().ToString();

                    }
                }

            }
            else
            {
                MessageBox.Show("Erro ao encontrar cargo.","Cargo não encontrado.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                lblCargo.Text = "404-Desconhecido";
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaLogin janela = new TelaLogin();

            janela.Visible = true;
            this.Close();
        }

        private void btnVerEstoque_Click(object sender, EventArgs e)
        {
            VerEstoque janela = new VerEstoque(listproduto, id);

            janela.Visible = true;
            this.Close();
        }

        private void btnGerenciarFuncionario_Click(object sender, EventArgs e)
        {
            GERENCIAR_FUNCIONARIOS func = new GERENCIAR_FUNCIONARIOS();
            func.Show();



        }
    }
}
