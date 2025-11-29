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
    public partial class TelaPagamento : Form
    {
        public TelaPagamento()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false; //esconde a primeira tabela em branco do datagrid
            dataGridView1.RowHeadersVisible = false;
        }

        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {

        }
    }
}
