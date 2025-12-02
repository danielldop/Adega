using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdegaStockFlow
{
    public partial class FrmHistoricoDesperdicio : Form
    {
        string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;
        public FrmHistoricoDesperdicio(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void CarregarHistorico(string nomeProduto, DateTime? dataFiltro)
        {
            using (var conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string sql = @"
            SELECT 
                h.id                AS 'Código',
                h.data_hora         AS 'Data/Hora',
                p.nome_produto      AS 'Produto',
                u.nome_usuario      AS 'Usuário',
                h.quantidade        AS 'Quantidade',
                h.motivo            AS 'Motivo',
                h.valor_compra      AS 'Valor compra',
                h.valor_venda       AS 'Valor venda',
                (h.valor_compra * h.quantidade) AS 'Custo total'
            FROM historico_desperdicio h
            JOIN produtos p ON p.cod_produto = h.cod_produto
            JOIN usuarios u ON u.cod_usuario = h.cod_usuario
            WHERE 1 = 1";

                
                if (!string.IsNullOrWhiteSpace(nomeProduto))
                {
                    sql += " AND p.nome_produto LIKE @nome";
                }

               
                if (dataFiltro.HasValue)
                {
                    sql += " AND DATE(h.data_hora) = @data";
                }

                sql += " ORDER BY h.data_hora DESC;";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrWhiteSpace(nomeProduto))
                        cmd.Parameters.AddWithValue("@nome", "%" + nomeProduto + "%");

                    if (dataFiltro.HasValue)
                        cmd.Parameters.AddWithValue("@data", dataFiltro.Value.Date);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        da.Fill(tabela);

                        dgvHistoricoDesperdicio.DataSource = tabela;
                        dgvHistoricoDesperdicio.ReadOnly = true;
                        dgvHistoricoDesperdicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvHistoricoDesperdicio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
        }

        private void FrmHistoricoDesperdicio_Load(object sender, EventArgs e)
        {
            txtProduto.Clear();
            dtpData.Checked = false;

            CarregarHistorico(null, null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtProduto.Text.Trim();
            DateTime? dataFiltro = null;

            if (dtpData.Checked)
            {
                dataFiltro = dtpData.Value.Date;
            }

            CarregarHistorico(nomeProduto, dataFiltro);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }
    }
}
