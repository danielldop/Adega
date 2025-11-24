namespace AdegaStockFlow
{
    partial class TelaRecuperarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRecuperarSenha));
            this.txtBoxBanda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.lblMostraSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxBanda
            // 
            this.txtBoxBanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBanda.Location = new System.Drawing.Point(267, 318);
            this.txtBoxBanda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxBanda.Name = "txtBoxBanda";
            this.txtBoxBanda.Size = new System.Drawing.Size(382, 53);
            this.txtBoxBanda.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite o ID do seu Usuário";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(336, 525);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(228, 58);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Location = new System.Drawing.Point(376, 394);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(163, 58);
            this.btnRecuperar.TabIndex = 9;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // lblMostraSenha
            // 
            this.lblMostraSenha.AutoSize = true;
            this.lblMostraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraSenha.Location = new System.Drawing.Point(384, 99);
            this.lblMostraSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostraSenha.Name = "lblMostraSenha";
            this.lblMostraSenha.Size = new System.Drawing.Size(0, 33);
            this.lblMostraSenha.TabIndex = 10;
            // 
            // TelaRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 692);
            this.Controls.Add(this.lblMostraSenha);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxBanda);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelaRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Senha";
            this.Load += new System.EventHandler(this.TelaRecuperarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxBanda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Label lblMostraSenha;
    }
}