namespace AdegaStockFlow
{
    partial class FrmCadastrarFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFuncionario = new System.Windows.Forms.RadioButton();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(6, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(381, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(6, 103);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(191, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 87);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(36, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Login:";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(6, 150);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(191, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(6, 195);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(191, 20);
            this.txtConfirmarSenha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirme sua senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nivel de acesso:";
            // 
            // rbFuncionario
            // 
            this.rbFuncionario.AutoSize = true;
            this.rbFuncionario.Location = new System.Drawing.Point(6, 256);
            this.rbFuncionario.Name = "rbFuncionario";
            this.rbFuncionario.Size = new System.Drawing.Size(80, 17);
            this.rbFuncionario.TabIndex = 9;
            this.rbFuncionario.TabStop = true;
            this.rbFuncionario.Text = "Funcionário";
            this.rbFuncionario.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(112, 256);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rbAdministrador.TabIndex = 10;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCargo.Location = new System.Drawing.Point(6, 314);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(191, 20);
            this.txtCargo.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(522, 368);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(149, 46);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 428);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCadastrar);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.txtCargo);
            this.groupBox2.Controls.Add(this.txtLogin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rbAdministrador);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.rbFuncionario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtConfirmarSenha);
            this.groupBox2.Location = new System.Drawing.Point(111, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 420);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar";
            // 
            // FrmCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadastrarFuncionario";
            this.Text = "FrmCadastrarFuncionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFuncionario;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}