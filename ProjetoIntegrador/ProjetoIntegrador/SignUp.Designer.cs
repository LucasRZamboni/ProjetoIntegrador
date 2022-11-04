namespace ProjetoIntegrador
{
    partial class SignUp
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label label3;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEntrar = new System.Windows.Forms.LinkLabel();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTermos = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cSenha2 = new System.Windows.Forms.PictureBox();
            this.cSenha = new System.Windows.Forms.PictureBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSenha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSenha)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.White;
            nomeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            nomeLabel.Location = new System.Drawing.Point(170, 43);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(35, 15);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            nomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.White;
            emailLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            emailLabel.Location = new System.Drawing.Point(171, 73);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.White;
            senhaLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senhaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            senhaLabel.Location = new System.Drawing.Point(167, 105);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(37, 15);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha";
            senhaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            label3.Location = new System.Drawing.Point(178, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(26, 15);
            label3.TabIndex = 10;
            label3.Text = "CPF";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 30);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.BackgroundImage = global::ProjetoIntegrador.Properties.Resources.seta_esquerda3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.Location = new System.Drawing.Point(237, -1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(30, 30);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sign up";
            // 
            // lbEntrar
            // 
            this.lbEntrar.AutoSize = true;
            this.lbEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.lbEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEntrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntrar.Location = new System.Drawing.Point(151, 278);
            this.lbEntrar.Name = "lbEntrar";
            this.lbEntrar.Size = new System.Drawing.Size(29, 12);
            this.lbEntrar.TabIndex = 7;
            this.lbEntrar.TabStop = true;
            this.lbEntrar.Text = "Entrar";
            this.lbEntrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbEntrar_LinkClicked);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCriarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarConta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.ForeColor = System.Drawing.Color.White;
            this.btnCriarConta.Location = new System.Drawing.Point(47, 211);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(175, 28);
            this.btnCriarConta.TabIndex = 5;
            this.btnCriarConta.Text = "Criar conta";
            this.btnCriarConta.UseVisualStyleBackColor = false;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Já tem uma conta?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTermos
            // 
            this.cbTermos.AutoSize = true;
            this.cbTermos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.cbTermos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTermos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTermos.Font = new System.Drawing.Font("Franklin Gothic Medium", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTermos.ForeColor = System.Drawing.Color.White;
            this.cbTermos.Location = new System.Drawing.Point(49, 245);
            this.cbTermos.Name = "cbTermos";
            this.cbTermos.Size = new System.Drawing.Size(131, 15);
            this.cbTermos.TabIndex = 6;
            this.cbTermos.Text = "Eu aceito os termos e condições";
            this.cbTermos.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.cSenha2);
            this.panel2.Controls.Add(this.cSenha);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(this.cPFMaskedTextBox);
            this.panel2.Controls.Add(senhaLabel);
            this.panel2.Controls.Add(emailLabel);
            this.panel2.Controls.Add(nomeLabel);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.senhaTextBox);
            this.panel2.Controls.Add(this.nomeTextBox);
            this.panel2.Location = new System.Drawing.Point(18, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 138);
            this.panel2.TabIndex = 14;
            // 
            // cSenha2
            // 
            this.cSenha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.cSenha2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cSenha2.Image = global::ProjetoIntegrador.Properties.Resources.olho2;
            this.cSenha2.Location = new System.Drawing.Point(205, 103);
            this.cSenha2.Name = "cSenha2";
            this.cSenha2.Size = new System.Drawing.Size(20, 20);
            this.cSenha2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cSenha2.TabIndex = 36;
            this.cSenha2.TabStop = false;
            this.cSenha2.Click += new System.EventHandler(this.cSenha2_MouseClick);
            // 
            // cSenha
            // 
            this.cSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.cSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cSenha.Image = global::ProjetoIntegrador.Properties.Resources.olho1;
            this.cSenha.Location = new System.Drawing.Point(206, 103);
            this.cSenha.Name = "cSenha";
            this.cSenha.Size = new System.Drawing.Size(20, 20);
            this.cSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cSenha.TabIndex = 35;
            this.cSenha.TabStop = false;
            this.cSenha.Click += new System.EventHandler(this.cSenha1_MouseClick);
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(12, 12);
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(194, 20);
            this.cPFMaskedTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(12, 71);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(194, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(11, 103);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(194, 20);
            this.senhaTextBox.TabIndex = 4;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(12, 41);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(194, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ProjetoIntegrador.Properties.Resources.WhatsApp_Image_2022_09_19_at_10_09_45_PM;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnCriarConta);
            this.panel3.Controls.Add(this.cbTermos);
            this.panel3.Controls.Add(this.lbEntrar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 404);
            this.panel3.TabIndex = 15;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrever";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSenha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSenha)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbEntrar;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTermos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.PictureBox cSenha2;
        private System.Windows.Forms.PictureBox cSenha;
        private System.Windows.Forms.Panel panel3;
    }
}