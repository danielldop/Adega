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
    public partial class GERENCIAR_FUNCIONARIOS : Form
    {
        
        public GERENCIAR_FUNCIONARIOS()
        {
            InitializeComponent();
        }

        private void bt_sair_cadastroFunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cadastrar_cadastroFunc_Click(object sender, EventArgs e)
        {
            tb_id_cadastroFunc.Clear();
            tb_nome_cadastroFunc.Clear();
            tb_cargo_cadastroFunc.Clear();
            tb_senha_cadastroFunc.Clear();
            tb_id_cadastroFunc.Focus();

            MessageBox.Show("CADASTRADO COM SUCESSO!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_id_cadastroFunc.Focus();
            
            lb_Id_buscaFunc.Visible = false;
            lb_nome_buscaFunc.Visible = false;

            tb_id_buscaFunc.Visible = false;
            tb_nome_buscaFunc.Visible = false;

            bt_pesquisaFunc.Visible = false;

            lb_id_CadastroFunc.Visible = true;
            lb_nome_cadastroFunc.Visible=true;
            lb_cargo_cadastroFunc.Visible = true;
            lb_senha_cadastroFunc.Visible = true;

            tb_id_cadastroFunc.Visible = true;
            tb_nome_cadastroFunc.Visible= true;
            tb_cargo_cadastroFunc.Visible = true;
            tb_senha_cadastroFunc.Visible = true;

            bt_cadastrar_cadastroFunc.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_id_buscaFunc.Focus();

            bt_cadastrar_cadastroFunc.Visible = false;

            lb_Id_buscaFunc.Visible = true;
            lb_nome_buscaFunc.Visible = true;
            
            tb_id_buscaFunc.Visible=true;
            tb_nome_buscaFunc.Visible = true;

            lb_id_CadastroFunc.Visible = false;
            lb_nome_cadastroFunc.Visible = false;
            lb_cargo_cadastroFunc.Visible = false;
            lb_senha_cadastroFunc.Visible = false;

            tb_id_cadastroFunc.Visible = false;
            tb_nome_cadastroFunc.Visible = false;
            tb_cargo_cadastroFunc.Visible = false;
            tb_senha_cadastroFunc.Visible = false;

            bt_cadastrar_cadastroFunc.Visible = false;
            bt_pesquisaFunc.Visible = true;
        }
    }
}
