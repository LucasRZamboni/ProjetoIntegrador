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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.DarkGray;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var entrar = new SignIn();
            this.Hide();
            entrar.ShowDialog();
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


        private void btnAjuda_Click(object sender, EventArgs e)
        {
            var help = new Help();
            this.Hide();
            help.ShowDialog();
        }

        private void btnAjuda_Leave(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.Transparent;
        }

        private void btnAjuda_MouseEnter(object sender, EventArgs e)
        {
            btnAjuda.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void btnConteudo_Click(object sender, EventArgs e)
        {
            var conteudo = new Conteudo();
            this.Hide();
            conteudo.ShowDialog();
        }

        private void btnConteudo_MouseEnter(object sender, EventArgs e)
        {
            btnConteudo.BackColor = Color.FromArgb(0, 64, 0);
        }
        private void btnConteudo_MouseLeave(object sender, EventArgs e)
        {
            btnConteudo.BackColor = Color.Transparent;
        }

        private void btnMapas_Click(object sender, EventArgs e)
        {
            var mapa = new Mapa();
            this.Hide();
            mapa.ShowDialog();
        }
        private void btnMapas_MouseEnter(object sender, EventArgs e)
        {
            btnMapas.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void btnMapas_MouseLeave(object sender, EventArgs e)
        {
            btnMapas.BackColor = Color.Transparent;
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            var contato = new Contato();
            this.Hide();
            contato.ShowDialog();
        }
        private void btnContato_MouseEnter(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.FromArgb(0, 64, 0);
        }
        private void btnContato_MouseLeave(object sender, EventArgs e)
        {
            btnContato.BackColor = Color.Transparent;
        }
        private void btnFatec_Click(object sender, EventArgs e)
        {
            var fatec = new Fatec();
            this.Hide();
            fatec.ShowDialog();
        }
        private void btnFatec_MouseEnter(object sender, EventArgs e)
        {
            btnFatec.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void btnFatec_MouseLeave(object sender, EventArgs e)
        {
            btnFatec.BackColor = Color.Transparent;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            var sobre = new Sobre();
            this.Hide();
            sobre.ShowDialog();
        }
        private void btnSobre_MouseEnter(object sender, EventArgs e)
        {
            btnSobre.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void btnSobre_MouseLeave(object sender, EventArgs e)
        {
            btnSobre.BackColor = Color.Transparent;
        }


        private void Ecolog_MouseEnter(object sender, EventArgs e)
        {
            Ecolog2.Visible = false;
            pbEcolog.Visible = false;

        }
        private void Ecolog_MouseLeave(object sender, EventArgs e)
        {
            Ecolog2.Visible = true;
            pbEcolog.Visible = true;
        }
    }
}
