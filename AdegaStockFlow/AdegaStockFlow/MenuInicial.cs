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
    public partial class MenuInicial : Form
    {
        private int usuarioLogado;
        private int acesso;

        public MenuInicial(int idUsuario)
        {
            InitializeComponent();
            this.usuarioLogado = idUsuario;
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {
            using (var conexao = Banco.GetConnection())
            {
                try
                {
                    conexao.Open();

                    string sql = @"
                SELECT cod_usuario, nome_usuario, cargo_usuario, nivel_usuario
                FROM usuarios
                WHERE cod_usuario = @id;";
                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", usuarioLogado);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nome = reader.GetString("nome_usuario");
                                string cargo = reader.GetString("cargo_usuario");
                                string nivel = reader.GetString("nivel_usuario");

                                lblNome.Text = nome;
                                lblCargo.Text = cargo;
                                lblId.Text = usuarioLogado.ToString();

                                if (nivel == "1")
                                {
                                    acesso = 1;
                                }
                                else if (nivel == "2")
                                {
                                    acesso = 2;
                                }
                                else
                                {
                                    MessageBox.Show("Usuário não encontrado!");
                                    return;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar usuário: " + ex.Message);
                    return;
                }
            }
            if (acesso == 1)
            {
                this.Controls.Remove(btnControleDesperdicio);
                btnControleDesperdicio.Dispose();

                this.Controls.Remove(btnHistoricoDesperdicio);
                btnHistoricoDesperdicio.Dispose();

                this.Controls.Remove(btnGerenciarFuncionario);
                btnGerenciarFuncionario.Dispose();

                btnSair.Size = new System.Drawing.Size(429, 37);
                btnSair.Location = new System.Drawing.Point(129, 400);
            }
            else if (acesso == 2)
            {
                //acesso completo, não faz nada
            }
            else
            {
                MessageBox.Show("Erro ao encontrar cargo!", "Cargo não encontrado!",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCargo.Text = "404-Desconhecido";
            }
        }
            

            
    

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaLogin janela = new TelaLogin();

            janela.Visible = true;
            this.Hide();
        }

        private void btnGerenciarFuncionario_Click(object sender, EventArgs e)
        {
            GERENCIAR_FUNCIONARIOS func = new GERENCIAR_FUNCIONARIOS(/*usuarioLogado*/);//passa usuario para que o botao voltar funcione

            func.Show();
            this.Hide();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FrmVenda novaTela = new FrmVenda(/*usuarioLogado*/);

            novaTela.Show();
            this.Hide();
        }

        private void btnHistoricoVendas_Click(object sender, EventArgs e)
        {
            FrmHistoricoDeVendas novaTela = new FrmHistoricoDeVendas(/*usuarioLogado*/);

            novaTela.Show();
            this.Hide();
        }

        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
            FrmGerenciarProdutos novaTela = new FrmGerenciarProdutos(usuarioLogado);

            novaTela.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes novaTela = new FrmClientes(usuarioLogado);

            novaTela.Show();
            this.Hide();
        }

        private void btnControleDesperdicio_Click(object sender, EventArgs e)
        {
            FrmDesperdicio novaTela = new FrmDesperdicio(/*usuarioLogado*/);

            novaTela.Show();
            this.Hide();
        }

        private void btnHistoricoDesperdicio_Click(object sender, EventArgs e)
        {
            FrmHistoricoDesperdicio novaTela = new FrmHistoricoDesperdicio(/*usuarioLogado*/);

            novaTela.Show();
            this.Hide();
        }
    }
}
