namespace AdegaStockFlow
{
    partial class FrmVenda
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lbldata = new System.Windows.Forms.Label();
            this.btnfinalizarvenda = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(54, 34);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 5;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(391, 31);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(163, 24);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(62, 76);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(0, 13);
            this.lblEndereco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVoltar);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.cmbProduto);
            this.groupBox2.Controls.Add(this.dgvCarrinho);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(391, 32);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(35, 20);
            this.txtQuantidade.TabIndex = 15;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(9, 31);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(376, 21);
            this.cmbProduto.TabIndex = 14;
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Produto,
            this.Quantidade,
            this.Preco,
            this.Subtotal});
            this.dgvCarrinho.Location = new System.Drawing.Point(9, 68);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.ReadOnly = true;
            this.dgvCarrinho.RowHeadersWidth = 62;
            this.dgvCarrinho.Size = new System.Drawing.Size(548, 296);
            this.dgvCarrinho.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 8;
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 8;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 150;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço Unit.";
            this.Preco.MinimumWidth = 8;
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 150;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 8;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(432, 29);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(125, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(787, 9);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 13);
            this.lbldata.TabIndex = 2;
            // 
            // btnfinalizarvenda
            // 
            this.btnfinalizarvenda.BackColor = System.Drawing.SystemColors.Control;
            this.btnfinalizarvenda.Location = new System.Drawing.Point(590, 488);
            this.btnfinalizarvenda.Name = "btnfinalizarvenda";
            this.btnfinalizarvenda.Size = new System.Drawing.Size(288, 64);
            this.btnfinalizarvenda.TabIndex = 3;
            this.btnfinalizarvenda.Text = "Finalizar Venda";
            this.btnfinalizarvenda.UseVisualStyleBackColor = false;
            this.btnfinalizarvenda.Click += new System.EventHandler(this.btnfinalizarvenda_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(590, 457);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(650, 457);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "89,90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subtotal:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Location = new System.Drawing.Point(652, 432);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(69, 20);
            this.txtDesconto.TabIndex = 8;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(659, 413);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(34, 13);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "90,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(628, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "R$";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(6, 396);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 23);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 564);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnfinalizarvenda);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVenda";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Button btnfinalizarvenda;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnVoltar;
    }
}