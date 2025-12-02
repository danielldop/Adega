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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPagamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
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
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaCod,
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 62;
            this.dgvProdutos.Size = new System.Drawing.Size(442, 193);
            this.dgvProdutos.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forma de pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor Recebido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Troco:";
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(253, 234);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(204, 21);
            this.cmbFormaPagamento.TabIndex = 7;
            this.cmbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPagamento_SelectedIndexChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(230, 408);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(125, 32);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(99, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 32);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelarPagamento_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Location = new System.Drawing.Point(357, 261);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 15;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Location = new System.Drawing.Point(357, 288);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 16;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(357, 314);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorRecebido.Location = new System.Drawing.Point(357, 340);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(100, 20);
            this.txtValorRecebido.TabIndex = 18;
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            // 
            // txtTroco
            // 
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Location = new System.Drawing.Point(357, 366);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(100, 20);
            this.txtTroco.TabIndex = 19;
            // 
            // TelaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 452);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtValorRecebido);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.cmbFormaPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPagamento";
            this.Text = "  PAGAMENTO";
            this.Load += new System.EventHandler(this.TelaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProdutos;
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
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.TextBox txtTroco;
    }
}