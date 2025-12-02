namespace AdegaStockFlow
{
    partial class FrmNovaSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtConfirmarSenha);
            this.groupBox1.Controls.Add(this.txtNovaSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Redefinir Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirme a senha:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNovaSenha.Location = new System.Drawing.Point(102, 155);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(270, 40);
            this.txtNovaSenha.TabIndex = 2;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(378, 155);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(270, 40);
            this.txtConfirmarSenha.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(469, 211);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(179, 46);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmNovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNovaSenha";
            this.Text = "NovaSenha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
    }
}