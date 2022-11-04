using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProjetoIntegrador
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();

        }
        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            btnVoltar.BackColor = Color.FromArgb(0, 64, 0);
        }
        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            btnVoltar.BackColor = Color.DarkGray;
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


        private void Sobre2_MouseEnter(object sender, EventArgs e)
        {
            Sobre2.Visible = false;
            pSobre2.Visible = false;

        }

        private void gitGabriela_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process pStart = new Process();
            pStart.StartInfo = new ProcessStartInfo(@"https://github.com/llgabriela");
            pStart.Start();
        
        }

        private void gitLuis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process pStart = new Process();
            pStart.StartInfo = new ProcessStartInfo(@"https://github.com/luishsilvajs");
            pStart.Start();
        }

        private void gitLucas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process pStart = new Process();
            pStart.StartInfo = new ProcessStartInfo(@"https://github.com/LucasRZamboni");
            pStart.Start();
        }

        private void Sobre2_MouseLeave(object sender, EventArgs e)
        {
            Sobre2.Visible = true;
            pSobre2.Visible = true;
        }
        private void git4_MouseEnter(object sender, EventArgs e)
        {
            git4.Visible = false;
            

        }
        private void git5_MouseEnter(object sender, EventArgs e)
        {
            git5.Visible = false;
           

        }
        private void git6_MouseEnter(object sender, EventArgs e)
        {
            git6.Visible = false;
           

        }
        private void git4_MouseLeave(object sender, EventArgs e)
        {
            git4.Visible = true;
            
        }
        private void git5_MouseLeave(object sender, EventArgs e)
        {
            git5.Visible = true;
            
        }
        private void git6_MouseLeave(object sender, EventArgs e)
        {
            git6.Visible = true;
            
        }
    }
}
