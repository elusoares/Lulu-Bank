namespace Lulu_Bank
{
    partial class TelaCadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxDinheiro = new System.Windows.Forms.PictureBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNasc = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNasc = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelNovoUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDinheiro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelNovoUsuario);
            this.panel1.Controls.Add(this.labelTel);
            this.panel1.Controls.Add(this.maskedTextBoxTel);
            this.panel1.Controls.Add(this.labelGenero);
            this.panel1.Controls.Add(this.labelNasc);
            this.panel1.Controls.Add(this.labelCpf);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.maskedTextBoxCpf);
            this.panel1.Controls.Add(this.comboBoxGenero);
            this.panel1.Controls.Add(this.maskedTextBoxNasc);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Location = new System.Drawing.Point(128, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 344);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxDinheiro
            // 
            this.pictureBoxDinheiro.Image = global::Lulu_Bank.Properties.Resources.dinheiro;
            this.pictureBoxDinheiro.Location = new System.Drawing.Point(24, 33);
            this.pictureBoxDinheiro.Name = "pictureBoxDinheiro";
            this.pictureBoxDinheiro.Size = new System.Drawing.Size(81, 67);
            this.pictureBoxDinheiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDinheiro.TabIndex = 1;
            this.pictureBoxDinheiro.TabStop = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(101, 86);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(228, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxNasc
            // 
            this.maskedTextBoxNasc.Location = new System.Drawing.Point(101, 139);
            this.maskedTextBoxNasc.Mask = "00/00/0000";
            this.maskedTextBoxNasc.Name = "maskedTextBoxNasc";
            this.maskedTextBoxNasc.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBoxNasc.TabIndex = 5;
            this.maskedTextBoxNasc.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro"});
            this.comboBoxGenero.Location = new System.Drawing.Point(101, 192);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(94, 21);
            this.comboBoxGenero.TabIndex = 6;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(249, 139);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBoxCpf.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNome.Location = new System.Drawing.Point(57, 89);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome:";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCpf.Location = new System.Drawing.Point(213, 142);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(30, 13);
            this.labelCpf.TabIndex = 9;
            this.labelCpf.Text = "CPF:";
            this.labelCpf.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNasc
            // 
            this.labelNasc.AutoSize = true;
            this.labelNasc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNasc.Location = new System.Drawing.Point(20, 142);
            this.labelNasc.Name = "labelNasc";
            this.labelNasc.Size = new System.Drawing.Size(79, 13);
            this.labelNasc.TabIndex = 10;
            this.labelNasc.Text = "Data de Nasc.:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGenero.Location = new System.Drawing.Point(50, 195);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 13);
            this.labelGenero.TabIndex = 11;
            this.labelGenero.Text = "Gênero:";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(249, 192);
            this.maskedTextBoxTel.Mask = "(99) 00000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBoxTel.TabIndex = 12;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTel.Location = new System.Drawing.Point(215, 195);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(28, 13);
            this.labelTel.TabIndex = 13;
            this.labelTel.Text = "Tel.:";
            // 
            // labelNovoUsuario
            // 
            this.labelNovoUsuario.AutoSize = true;
            this.labelNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovoUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNovoUsuario.Location = new System.Drawing.Point(108, 18);
            this.labelNovoUsuario.Name = "labelNovoUsuario";
            this.labelNovoUsuario.Size = new System.Drawing.Size(136, 24);
            this.labelNovoUsuario.TabIndex = 14;
            this.labelNovoUsuario.Text = "Novo Usuário";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(82, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(183, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(20, 103);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(88, 22);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Lulu Bank";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(520, 405);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxDinheiro);
            this.Controls.Add(this.panel1);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDinheiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDinheiro;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNasc;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelNasc;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNovoUsuario;
        private System.Windows.Forms.Label labelTitle;
    }
}