namespace AdegaStockFlow
{
    partial class FrmHistoricoDeVendas
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvHistoricoVendas = new System.Windows.Forms.DataGridView();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.dgvHistoricoVendas);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(683, 69);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvHistoricoVendas
            // 
            this.dgvHistoricoVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoVendas.Location = new System.Drawing.Point(9, 98);
            this.dgvHistoricoVendas.Name = "dgvHistoricoVendas";
            this.dgvHistoricoVendas.Size = new System.Drawing.Size(761, 322);
            this.dgvHistoricoVendas.TabIndex = 4;
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Location = new System.Drawing.Point(9, 72);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(421, 20);
            this.txtProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(6, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(436, 72);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(241, 20);
            this.dtpData.TabIndex = 7;
            // 
            // FrmHistoricoDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHistoricoDeVendas";
            this.Text = "FrmHistoricoDeVendas";
            this.Load += new System.EventHandler(this.FrmHistoricoDeVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvHistoricoVendas;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}