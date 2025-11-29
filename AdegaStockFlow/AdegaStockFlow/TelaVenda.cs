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
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }


        private void FrmVenda_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldata.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
