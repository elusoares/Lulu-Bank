namespace Lulu_Bank
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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxDinheiro = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelCadastreSe = new System.Windows.Forms.LinkLabel();
            this.labelNaoTemUmaConta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDinheiro)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(69, 50);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(163, 20);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(69, 84);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(163, 20);
            this.textBoxSenha.TabIndex = 1;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCpf.Location = new System.Drawing.Point(32, 53);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(30, 13);
            this.labelCpf.TabIndex = 2;
            this.labelCpf.Text = "CPF:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSenha.Location = new System.Drawing.Point(20, 87);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonLogin.Location = new System.Drawing.Point(88, 133);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.labelCpf);
            this.panel1.Controls.Add(this.labelSenha);
            this.panel1.Controls.Add(this.textBoxSenha);
            this.panel1.Location = new System.Drawing.Point(68, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 185);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bem vindo(a)";
            // 
            // pictureBoxDinheiro
            // 
            this.pictureBoxDinheiro.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDinheiro.Image = global::Lulu_Bank.Properties.Resources.dinheiro1;
            this.pictureBoxDinheiro.Location = new System.Drawing.Point(156, 12);
            this.pictureBoxDinheiro.Name = "pictureBoxDinheiro";
            this.pictureBoxDinheiro.Size = new System.Drawing.Size(75, 60);
            this.pictureBoxDinheiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDinheiro.TabIndex = 6;
            this.pictureBoxDinheiro.TabStop = false;
            this.pictureBoxDinheiro.Click += new System.EventHandler(this.pictureBoxDinheiro_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(117, 75);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(157, 39);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Lulu Bank";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.linkLabelCadastreSe);
            this.panel2.Controls.Add(this.labelNaoTemUmaConta);
            this.panel2.Location = new System.Drawing.Point(68, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 37);
            this.panel2.TabIndex = 8;
            // 
            // linkLabelCadastreSe
            // 
            this.linkLabelCadastreSe.AutoSize = true;
            this.linkLabelCadastreSe.LinkColor = System.Drawing.Color.White;
            this.linkLabelCadastreSe.Location = new System.Drawing.Point(143, 11);
            this.linkLabelCadastreSe.Name = "linkLabelCadastreSe";
            this.linkLabelCadastreSe.Size = new System.Drawing.Size(63, 13);
            this.linkLabelCadastreSe.TabIndex = 1;
            this.linkLabelCadastreSe.TabStop = true;
            this.linkLabelCadastreSe.Text = "Cadastre-se";
            // 
            // labelNaoTemUmaConta
            // 
            this.labelNaoTemUmaConta.AutoSize = true;
            this.labelNaoTemUmaConta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNaoTemUmaConta.Location = new System.Drawing.Point(41, 11);
            this.labelNaoTemUmaConta.Name = "labelNaoTemUmaConta";
            this.labelNaoTemUmaConta.Size = new System.Drawing.Size(106, 13);
            this.labelNaoTemUmaConta.TabIndex = 0;
            this.labelNaoTemUmaConta.Text = "Não tem uma conta?";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(385, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxDinheiro);
            this.Controls.Add(this.panel1);
            this.Name = "TelaLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDinheiro)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelSenha;
        public System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelCadastreSe;
        private System.Windows.Forms.Label labelNaoTemUmaConta;
    }
}

