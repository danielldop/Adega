namespace AdegaStockFlow
{
    partial class FrmEditarProdutos
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnVisualizarEstoque = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQtdEntrada = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Controls.Add(this.btnVisualizarEstoque);
            this.groupBox1.Controls.Add(this.btnExcluirProduto);
            this.groupBox1.Controls.Add(this.btnEditarProduto);
            this.groupBox1.Controls.Add(this.btnAdicionarProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(6, 235);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(82, 47);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnVisualizarEstoque
            // 
            this.btnVisualizarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarEstoque.Location = new System.Drawing.Point(6, 181);
            this.btnVisualizarEstoque.Name = "btnVisualizarEstoque";
            this.btnVisualizarEstoque.Size = new System.Drawing.Size(82, 48);
            this.btnVisualizarEstoque.TabIndex = 4;
            this.btnVisualizarEstoque.Text = "Estoque";
            this.btnVisualizarEstoque.UseVisualStyleBackColor = true;
            this.btnVisualizarEstoque.Click += new System.EventHandler(this.btnVisualizarEstoque_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Location = new System.Drawing.Point(6, 127);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(82, 48);
            this.btnExcluirProduto.TabIndex = 3;
            this.btnExcluirProduto.Text = "Desativar";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Location = new System.Drawing.Point(6, 73);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(82, 48);
            this.btnEditarProduto.TabIndex = 2;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(6, 19);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(82, 48);
            this.btnAdicionarProduto.TabIndex = 1;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQtdEntrada);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.txtValorVenda);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtValorCompra);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbProduto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(112, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Produtos";
            // 
            // txtQtdEntrada
            // 
            this.txtQtdEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdEntrada.Location = new System.Drawing.Point(528, 54);
            this.txtQtdEntrada.Name = "txtQtdEntrada";
            this.txtQtdEntrada.Size = new System.Drawing.Size(42, 20);
            this.txtQtdEntrada.TabIndex = 22;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(482, 144);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorVenda.Location = new System.Drawing.Point(85, 147);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Valor de venda:";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorCompra.Location = new System.Drawing.Point(85, 107);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 20);
            this.txtValorCompra.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor de compra:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(85, 53);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(437, 21);
            this.cmbProduto.TabIndex = 1;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // FrmEditarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditarProdutos";
            this.Text = "FrmEditarProdutos";
            this.Load += new System.EventHandler(this.FrmEditarProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnVisualizarEstoque;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtQtdEntrada;
    }
}