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
    public partial class LoginDeveloper : Form
    {
        public LoginDeveloper()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }
        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.DarkGray;
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text != "Dev" && tbSenha.Text != "123")
            {
                MessageBox.Show("Login or Password do not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Wellcome");
                var dev = new Desenvolvedor();
                this.Hide();
                dev.ShowDialog();
            }
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
    }
}
