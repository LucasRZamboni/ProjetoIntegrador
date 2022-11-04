using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        private void lbEcolog_MouseEnter(object sender, EventArgs e)
        {
            lbEcolog.ForeColor = Color.LimeGreen;
        }
        private void lbEcolog_MouseLeave(object sender, EventArgs e)
        {
            lbEcolog.ForeColor = Color.FromArgb(0, 64, 0);
        }

        /* Movimentar aplicativo na área de trabalho */
        private bool mover;
        private int cX, cY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - panel1.Left);
                this.Top += e.Y - (cY - panel1.Top);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var entrar = new SignIn();
            this.Hide();
            entrar.ShowDialog();
        }

        private void lbDesenvolvedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var logindev = new LoginDeveloper();
            this.Hide();
            logindev.ShowDialog();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.DarkGray;
        }

        private void lbInscrever_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var inscrever = new SignUp();
            this.Hide();
            inscrever.ShowDialog();
        }

        

    }
}
