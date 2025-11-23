namespace AdegaStockFlow
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.lblStockFlow = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.lblRecuperarSenha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbl_sair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStockFlow
            // 
            resources.ApplyResources(this.lblStockFlow, "lblStockFlow");
            this.lblStockFlow.BackColor = System.Drawing.Color.Transparent;
            this.lblStockFlow.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStockFlow.Name = "lblStockFlow";
            this.lblStockFlow.Click += new System.EventHandler(this.lblStockFlow_Click);
            // 
            // txtBoxUser
            // 
            resources.ApplyResources(this.txtBoxUser, "txtBoxUser");
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Enter += new System.EventHandler(this.txtBoxUser_Enter);
            this.txtBoxUser.Leave += new System.EventHandler(this.txtBoxUser_Leave);
            // 
            // txtBoxSenha
            // 
            resources.ApplyResources(this.txtBoxSenha, "txtBoxSenha");
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.UseSystemPasswordChar = true;
            this.txtBoxSenha.Enter += new System.EventHandler(this.txtBoxSenha_Enter);
            this.txtBoxSenha.Leave += new System.EventHandler(this.txtBoxSenha_Leave);
            // 
            // lblRecuperarSenha
            // 
            resources.ApplyResources(this.lblRecuperarSenha, "lblRecuperarSenha");
            this.lblRecuperarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecuperarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.lblRecuperarSenha.Name = "lblRecuperarSenha";
            this.lblRecuperarSenha.Click += new System.EventHandler(this.lblRecuperarSenha_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Name = "label4";
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseMnemonic = false;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbl_sair
            // 
            resources.ApplyResources(this.lbl_sair, "lbl_sair");
            this.lbl_sair.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Click += new System.EventHandler(this.lbl_sair_Click);
            // 
            // TelaLogin
            // 
            this.AcceptButton = this.btnEntrar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_sair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecuperarSenha);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lblStockFlow);
            this.Name = "TelaLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockFlow;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Label lblRecuperarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lbl_sair;
    }
}

