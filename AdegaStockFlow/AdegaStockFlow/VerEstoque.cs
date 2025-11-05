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
    public partial class VerEstoque : Form
    {
        List<Produto> listproduto;
        int id;
        public VerEstoque(List<Produto> listproduto,int id)
        {
            InitializeComponent();
            this.listproduto = listproduto;
            this.id = id;
        }

        private void VerEstoque_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = listproduto;
        }
    }
}
