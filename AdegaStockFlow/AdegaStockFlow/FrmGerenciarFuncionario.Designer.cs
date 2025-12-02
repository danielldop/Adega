namespace AdegaStockFlow
{
    partial class FrmGerenciarFuncionario
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbFuncionarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncionarioSelecionado = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 428);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 60);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(3, 153);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 60);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.txtFuncionarioSelecionado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvFuncionarios);
            this.groupBox2.Controls.Add(this.btnSelecionar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbFuncionarios);
            this.groupBox2.Location = new System.Drawing.Point(114, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 428);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar";
            // 
            // cmbFuncionarios
            // 
            this.cmbFuncionarios.FormattingEnabled = true;
            this.cmbFuncionarios.Location = new System.Drawing.Point(74, 60);
            this.cmbFuncionarios.Name = "cmbFuncionarios";
            this.cmbFuncionarios.Size = new System.Drawing.Size(461, 21);
            this.cmbFuncionarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionário";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(541, 58);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(119, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(9, 87);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(651, 249);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Funcionário selecionado: ";
            // 
            // txtFuncionarioSelecionado
            // 
            this.txtFuncionarioSelecionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncionarioSelecionado.Location = new System.Drawing.Point(140, 351);
            this.txtFuncionarioSelecionado.Name = "txtFuncionarioSelecionado";
            this.txtFuncionarioSelecionado.ReadOnly = true;
            this.txtFuncionarioSelecionado.Size = new System.Drawing.Size(244, 20);
            this.txtFuncionarioSelecionado.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(390, 349);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmGerenciarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGerenciarFuncionario";
            this.Text = "FrmGerenciarFuncionario";
            this.Load += new System.EventHandler(this.FrmGerenciarFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtFuncionarioSelecionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFuncionarios;
    }
}