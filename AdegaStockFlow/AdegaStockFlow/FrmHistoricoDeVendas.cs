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
    public partial class FrmHistoricoDeVendas : Form
    {
        private string stringDeConexao = @"server=127.0.0.1;database=adega;uid=root;";
        private int usuarioLogado;
        public FrmHistoricoDeVendas(int idUsuario)
        {
            InitializeComponent();
            usuarioLogado = idUsuario;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void CarregarHistoricoVendas(string nomeProduto, DateTime? dataFiltro)
        {
            try
            {
                using (var conexao = new MySqlConnection(stringDeConexao))
                {
                    conexao.Open();

                    string sql = @"
                SELECT 
                    h.cod_operacao                             AS 'Código',
                    h.data_hora                                AS 'Data/Hora',
                    p.nome_produto                             AS 'Produto',
                    COALESCE(c.nome_cliente, 'S/ Cadastro')    AS 'Cliente',
                    u.nome_usuario                             AS 'Usuário',
                    h.qtd_produto                              AS 'Quantidade',
                    h.valorVenda_produto                       AS 'Valor unitário',
                    (h.qtd_produto * h.valorVenda_produto)     AS 'Total linha',
                    h.tipo                                     AS 'Tipo',
                    CONCAT('Venda ', v.cod_venda)              AS 'Operação',
                    CASE v.forma_pagamento
                        WHEN 'DINHEIRO'       THEN 'Dinheiro'
                        WHEN 'PIX'            THEN 'Pix'
                        WHEN 'VISA_CREDITO'   THEN 'Visa Crédito'
                        WHEN 'MASTER_CREDITO' THEN 'Master Crédito'
                        WHEN 'VISA_DEBITO'    THEN 'Visa Débito'
                        WHEN 'MASTER_DEBITO'  THEN 'Master Débito'
                        ELSE v.forma_pagamento
                    END                                        AS 'Pagamento'
                FROM Historico_vendas h
                JOIN produtos p   ON p.cod_produto  = h.cod_produto
                JOIN usuarios u   ON u.cod_usuario  = h.cod_usuario
                LEFT JOIN vendas v 
                    ON v.cod_venda = CAST(SUBSTRING_INDEX(h.operacao, ' ', -1) AS UNSIGNED)
                LEFT JOIN clientes c 
                    ON c.cod_cliente = v.cod_cliente
                WHERE 1 = 1
            ";

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

                            dgvHistoricoVendas.DataSource = tabela;
                            dgvHistoricoVendas.ReadOnly = true;
                            dgvHistoricoVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dgvHistoricoVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            if (tabela.Columns.Contains("Valor unitário"))
                                dgvHistoricoVendas.Columns["Valor unitário"].DefaultCellStyle.Format = "N2";
                            if (tabela.Columns.Contains("Total linha"))
                                dgvHistoricoVendas.Columns["Total linha"].DefaultCellStyle.Format = "N2";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar histórico de vendas: " + ex.Message);
            }
        }


        private void FrmHistoricoDeVendas_Load(object sender, EventArgs e)
        {
            txtProduto.Clear();

            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.ShowCheckBox = true;
            dtpData.Checked = false; 

            CarregarHistoricoVendas(null, null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtProduto.Text.Trim();
            DateTime? dataFiltro = null;

            if (dtpData.Checked)
                dataFiltro = dtpData.Value.Date;

            CarregarHistoricoVendas(nomeProduto, dataFiltro);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial(usuarioLogado);
            menu.Show();
            this.Close();
        }
    }
}
