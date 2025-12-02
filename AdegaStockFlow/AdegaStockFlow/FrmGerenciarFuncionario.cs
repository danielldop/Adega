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
    public partial class FrmGerenciarFuncionario : Form
    {
        private string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;
        private int? funcionarioSelecionadoId = null;

        public FrmGerenciarFuncionario(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);

            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastrarFuncionario cadastrar = new FrmCadastrarFuncionario(usuarioLogado);

            cadastrar.Show();
            this.Close();
        }

        private void FrmGerenciarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionariosCombo();
            CarregarFuncionariosGrid();
            txtFuncionarioSelecionado.ReadOnly = true;
        }

        private void CarregarFuncionariosCombo()
        {
            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = @"
            SELECT cod_usuario, nome_usuario
            FROM usuarios
            WHERE cod_usuario <> @idLogado
            ORDER BY nome_usuario;";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@idLogado", usuarioLogado);

                    DataTable tabela = new DataTable();
                    da.Fill(tabela);

                    cmbFuncionarios.DataSource = tabela;
                    cmbFuncionarios.DisplayMember = "nome_usuario"; 
                    cmbFuncionarios.ValueMember = "cod_usuario";  
                    cmbFuncionarios.SelectedIndex = -1;
                }
            }

            funcionarioSelecionadoId = null;
            txtFuncionarioSelecionado.Text = "";
        }

        private void CarregarFuncionariosGrid()
        {
            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = @"
            SELECT 
                cod_usuario           AS 'Código',
                nome_usuario          AS 'Nome',
                login_usuario         AS 'Login',
                CASE 
                    WHEN nivel_usuario = 1 THEN 'Funcionário'
                    WHEN nivel_usuario = 2 THEN 'Administrador'
                    ELSE 'Desconhecido'
                END                   AS 'Nível de acesso',
                cargo_usuario         AS 'Cargo'
            FROM usuarios
            ORDER BY nome_usuario;";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    da.Fill(tabela);

                    dgvFuncionarios.DataSource = tabela;
                    dgvFuncionarios.ReadOnly = true;
                    dgvFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cmbFuncionarios.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um funcionário.");
                return;
            }

            funcionarioSelecionadoId = Convert.ToInt32(cmbFuncionarios.SelectedValue);
            string nome = cmbFuncionarios.Text;

            txtFuncionarioSelecionado.Text = nome;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (funcionarioSelecionadoId == null)
            {
                MessageBox.Show("Selecione um funcionário para excluir (use o botão Selecionar).");
                return;
            }

            if (funcionarioSelecionadoId == usuarioLogado)
            {
                MessageBox.Show("Você não pode excluir o usuário atualmente logado.");
                return;
            }

            string nome = txtFuncionarioSelecionado.Text;

            var resp = MessageBox.Show(
                $"Tem certeza que deseja excluir o funcionário:\n\n{nome} (ID: {funcionarioSelecionadoId})?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp == DialogResult.No)
                return;

            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = "DELETE FROM usuarios WHERE cod_usuario = @id;";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", funcionarioSelecionadoId.Value);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Funcionário excluído com sucesso!");

                        CarregarFuncionariosCombo();
                        CarregarFuncionariosGrid();
                        txtFuncionarioSelecionado.Text = "";
                        funcionarioSelecionadoId = null;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro foi excluído. Verifique o funcionário selecionado.");
                    }
                }
            }
        }
    }
}
