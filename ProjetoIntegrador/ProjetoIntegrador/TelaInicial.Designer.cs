namespace ProjetoIntegrador
{
    partial class TelaInicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbEcolog = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInscrever = new System.Windows.Forms.LinkLabel();
            this.lbDesenvolvedor = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::ProjetoIntegrador.Properties.Resources.cruz3;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnFechar.Location = new System.Drawing.Point(238, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 28);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // lbEcolog
            // 
            this.lbEcolog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEcolog.AutoSize = true;
            this.lbEcolog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEcolog.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEcolog.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbEcolog.Location = new System.Drawing.Point(91, 6);
            this.lbEcolog.Name = "lbEcolog";
            this.lbEcolog.Size = new System.Drawing.Size(82, 24);
            this.lbEcolog.TabIndex = 2;
            this.lbEcolog.Text = "ECOLOG";
            this.lbEcolog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEcolog.MouseEnter += new System.EventHandler(this.lbEcolog_MouseEnter);
            this.lbEcolog.MouseLeave += new System.EventHandler(this.lbEcolog_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meio Ambiente";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(55, 47);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(158, 26);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(65, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 11);
            this.label3.TabIndex = 5;
            this.label3.Text = "Não tem uma conta?                      aqui ";
            // 
            // lbInscrever
            // 
            this.lbInscrever.AutoSize = true;
            this.lbInscrever.BackColor = System.Drawing.Color.Transparent;
            this.lbInscrever.Font = new System.Drawing.Font("Franklin Gothic Medium", 6F);
            this.lbInscrever.Location = new System.Drawing.Point(139, 73);
            this.lbInscrever.Name = "lbInscrever";
            this.lbInscrever.Size = new System.Drawing.Size(44, 11);
            this.lbInscrever.TabIndex = 2;
            this.lbInscrever.TabStop = true;
            this.lbInscrever.Text = "Inscreva-se";
            this.lbInscrever.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbInscrever_LinkClicked);
            // 
            // lbDesenvolvedor
            // 
            this.lbDesenvolvedor.AutoSize = true;
            this.lbDesenvolvedor.BackColor = System.Drawing.Color.Transparent;
            this.lbDesenvolvedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 6F);
            this.lbDesenvolvedor.Location = new System.Drawing.Point(2, 96);
            this.lbDesenvolvedor.Name = "lbDesenvolvedor";
            this.lbDesenvolvedor.Size = new System.Drawing.Size(55, 11);
            this.lbDesenvolvedor.TabIndex = 7;
            this.lbDesenvolvedor.TabStop = true;
            this.lbDesenvolvedor.Text = "Desenvolvedor";
            this.lbDesenvolvedor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbDesenvolvedor_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbEcolog);
            this.panel2.Controls.Add(this.lbDesenvolvedor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbInscrever);
            this.panel2.Controls.Add(this.btnEntrar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 112);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ProjetoIntegrador.Properties.Resources.Sem_Título_;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 294);
            this.panel3.TabIndex = 9;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbEcolog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbInscrever;
        private System.Windows.Forms.LinkLabel lbDesenvolvedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

