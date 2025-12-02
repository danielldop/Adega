namespace AdegaStockFlow
{
    partial class FrmHistoricoDesperdicio
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
            this.group = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.dgvHistoricoDesperdicio = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoDesperdicio)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.dtpData);
            this.group.Controls.Add(this.btnVoltar);
            this.group.Controls.Add(this.btnPesquisar);
            this.group.Controls.Add(this.dgvHistoricoDesperdicio);
            this.group.Controls.Add(this.txtProduto);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label1);
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(776, 426);
            this.group.TabIndex = 2;
            this.group.TabStop = false;
            this.group.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Location = new System.Drawing.Point(9, 67);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(435, 20);
            this.txtProduto.TabIndex = 2;
            // 
            // dgvHistoricoDesperdicio
            // 
            this.dgvHistoricoDesperdicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoDesperdicio.Location = new System.Drawing.Point(9, 93);
            this.dgvHistoricoDesperdicio.Name = "dgvHistoricoDesperdicio";
            this.dgvHistoricoDesperdicio.Size = new System.Drawing.Size(761, 327);
            this.dgvHistoricoDesperdicio.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(683, 64);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(9, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(450, 67);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(227, 20);
            this.dtpData.TabIndex = 7;
            // 
            // FrmHistoricoDesperdicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.group);
            this.Name = "FrmHistoricoDesperdicio";
            this.Text = "FrmHistoricoDesperdicio";
            this.Load += new System.EventHandler(this.FrmHistoricoDesperdicio_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoDesperdicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvHistoricoDesperdicio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}