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
    public partial class Fatec : Form
    {
        public Fatec()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
