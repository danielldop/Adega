namespace AdegaStockFlow
{
    partial class FrmConsultaEstoque
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
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
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(6, 235);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(82, 47);
            this.btnMenu.TabIndex = 5;
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
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtProduto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvEstoque);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Location = new System.Drawing.Point(112, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 426);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estoque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produtos";
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Location = new System.Drawing.Point(286, 47);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(274, 20);
            this.txtProduto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar categorias";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(6, 73);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(664, 347);
            this.dgvEstoque.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(566, 46);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(6, 46);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(274, 21);
            this.cmbCategoria.TabIndex = 0;
            // 
            // FrmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaEstoque";
            this.Text = "FrmConsultaEstoque";
            this.Load += new System.EventHandler(this.FrmConsultaEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVisualizarEstoque;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduto;
    }
}