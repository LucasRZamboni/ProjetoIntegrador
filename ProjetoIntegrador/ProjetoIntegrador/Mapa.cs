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
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
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
        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

             string pais = tbPais.Text;
             string rua = tbRua.Text;
             string cidade = tbCidade.Text;
             string estado = tbEstado.Text;
             string cep = tbCEP.Text;

            StringBuilder filaendereco = new StringBuilder();
            filaendereco.Append("https://www.google.com/maps?q=");
            // filaendereco.Append("http://terrabrasilis.dpi.inpe.br/app/map/deforestation?hl=pt-br");


            if (pais != string.Empty)
            {
                filaendereco.Append(pais + "," + "+");
            }
            if (rua != string.Empty)
            {
                filaendereco.Append(rua + "," + "+");
            }
            if (cidade != string.Empty)
            {
                filaendereco.Append(cidade + "," + "+");
            }
            if (estado != string.Empty)
            {
                filaendereco.Append(estado + "," + "+");
            }
            if (cep != string.Empty)
            {
                filaendereco.Append(cep + "," + "+");
            }
            webBrowser1.Navigate(filaendereco.ToString());

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
