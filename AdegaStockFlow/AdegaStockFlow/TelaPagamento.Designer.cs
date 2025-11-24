namespace AdegaStockFlow
{
    partial class TelaPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColunaCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.btnFinalizarPagamento = new System.Windows.Forms.Button();
            this.btnCancelarPagamento = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(672, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaCod,
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(664, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColunaCod
            // 
            this.ColunaCod.HeaderText = "Código";
            this.ColunaCod.MinimumWidth = 8;
            this.ColunaCod.Name = "ColunaCod";
            this.ColunaCod.Width = 150;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 8;
            this.Produto.Name = "Produto";
            this.Produto.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 8;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 150;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 8;
            this.Valor.Name = "Valor";
            this.Valor.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forma de pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 526);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor Recebido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 566);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Troco:";
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Location = new System.Drawing.Point(380, 360);
            this.cbxFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(304, 28);
            this.cbxFormaPagamento.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(536, 402);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(148, 26);
            this.txtSubtotal.TabIndex = 8;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(536, 442);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(148, 26);
            this.txtDesconto.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(536, 482);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(148, 26);
            this.txtTotal.TabIndex = 10;
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Location = new System.Drawing.Point(536, 522);
            this.txtValorRecebido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(148, 26);
            this.txtValorRecebido.TabIndex = 11;
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(536, 562);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(148, 26);
            this.txtTroco.TabIndex = 12;
            // 
            // btnFinalizarPagamento
            // 
            this.btnFinalizarPagamento.Location = new System.Drawing.Point(152, 628);
            this.btnFinalizarPagamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinalizarPagamento.Name = "btnFinalizarPagamento";
            this.btnFinalizarPagamento.Size = new System.Drawing.Size(188, 49);
            this.btnFinalizarPagamento.TabIndex = 13;
            this.btnFinalizarPagamento.Text = "Finalizar";
            this.btnFinalizarPagamento.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPagamento
            // 
            this.btnCancelarPagamento.Location = new System.Drawing.Point(348, 628);
            this.btnCancelarPagamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarPagamento.Name = "btnCancelarPagamento";
            this.btnCancelarPagamento.Size = new System.Drawing.Size(188, 48);
            this.btnCancelarPagamento.TabIndex = 14;
            this.btnCancelarPagamento.Text = "Cancelar";
            this.btnCancelarPagamento.UseVisualStyleBackColor = true;
            // 
            // TelaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 695);
            this.Controls.Add(this.btnCancelarPagamento);
            this.Controls.Add(this.btnFinalizarPagamento);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtValorRecebido);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.cbxFormaPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelaPagamento";
            this.Text = "Pagamento";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxFormaPagamento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Button btnFinalizarPagamento;
        private System.Windows.Forms.Button btnCancelarPagamento;
    }
}