namespace ProjetoIntegrador
{
    partial class SignIn
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cSenha2 = new System.Windows.Forms.PictureBox();
            this.cSenha = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSenha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            label4.Location = new System.Drawing.Point(192, 173);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(37, 15);
            label4.TabIndex = 31;
            label4.Text = "Senha";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            label2.Location = new System.Drawing.Point(195, 135);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 15);
            label2.TabIndex = 30;
            label2.Text = "Email";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 30);
            this.panel1.TabIndex = 3;
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
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseEnter += new System.EventHandler(this.btnVoltar_MouseEnter);
            this.btnVoltar.MouseLeave += new System.EventHandler(this.btnVoltar_MouseLeave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(42, 222);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(185, 26);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbEsqueceuSenha
            // 
            this.lbEsqueceuSenha.AutoSize = true;
            this.lbEsqueceuSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.lbEsqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEsqueceuSenha.Font = new System.Drawing.Font("Franklin Gothic Medium", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEsqueceuSenha.Location = new System.Drawing.Point(96, 253);
            this.lbEsqueceuSenha.Name = "lbEsqueceuSenha";
            this.lbEsqueceuSenha.Size = new System.Drawing.Size(81, 12);
            this.lbEsqueceuSenha.TabIndex = 4;
            this.lbEsqueceuSenha.TabStop = true;
            this.lbEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lbEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbEsqueceuSenha_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Efetuar Login";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTextBox.Location = new System.Drawing.Point(44, 171);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(186, 20);
            this.senhaTextBox.TabIndex = 2;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(44, 133);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(186, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // cSenha2
            // 
            this.cSenha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.cSenha2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cSenha2.Image = global::ProjetoIntegrador.Properties.Resources.olho2;
            this.cSenha2.Location = new System.Drawing.Point(230, 170);
            this.cSenha2.Name = "cSenha2";
            this.cSenha2.Size = new System.Drawing.Size(20, 20);
            this.cSenha2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cSenha2.TabIndex = 34;
            this.cSenha2.TabStop = false;
            this.cSenha2.Click += new System.EventHandler(this.cSenha2_MouseClick);
            // 
            // cSenha
            // 
            this.cSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(102)))));
            this.cSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cSenha.Image = global::ProjetoIntegrador.Properties.Resources.olho1;
            this.cSenha.Location = new System.Drawing.Point(230, 171);
            this.cSenha.Name = "cSenha";
            this.cSenha.Size = new System.Drawing.Size(20, 20);
            this.cSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cSenha.TabIndex = 33;
            this.cSenha.TabStop = false;
            this.cSenha.Click += new System.EventHandler(this.cSenha1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoIntegrador.Properties.Resources.WhatsApp_Image_2022_09_19_at_10_09_45_PM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 433);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ProjetoIntegrador.Properties.Resources.WhatsApp_Image_2022_09_19_at_10_09_45_PM;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.cSenha2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnEntrar);
            this.panel2.Controls.Add(this.cSenha);
            this.panel2.Controls.Add(this.lbEsqueceuSenha);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.senhaTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 404);
            this.panel2.TabIndex = 35;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cSenha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lbEsqueceuSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox cSenha;
        private System.Windows.Forms.PictureBox cSenha2;
        private System.Windows.Forms.Panel panel2;
    }
}