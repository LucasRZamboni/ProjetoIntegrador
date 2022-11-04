using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        LoginDataSet.TableLoginDataTable cadastroSignup = new LoginDataSet.TableLoginDataTable();
        LoginDataSetTableAdapters.TableLoginTableAdapter cadastro = new LoginDataSetTableAdapters.TableLoginTableAdapter();

        LoginDataSetTableAdapters.TableLoginTableAdapter Signup = new LoginDataSetTableAdapters.TableLoginTableAdapter();




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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {

                Conexao conexao = new Conexao();

                string consulta = "SELECT Email, Senha FROM TableLogin WHERE Email = @Email and Senha = @Senha";

                SqlCommand cmd = new SqlCommand(consulta, Conexao.con);
                
                //Passo o parametro
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@Senha", senhaTextBox.Text);

                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    MessageBox.Show("Bem vindo!");

                    var menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();

                }
                //SENÃO NÃO ENTRA
                else
                {
                    MessageBox.Show("Email ou senha não correspondente");
                }

                Conexao.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var telainicial = new TelaInicial();
            this.Hide();
            telainicial.ShowDialog();
        }
        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            btnVoltar.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void lbEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recsenha = new RecSenha();
            this.Hide();
            recsenha.ShowDialog();
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            btnVoltar.BackColor = Color.DarkGray;
        }
        private void cSenha2_MouseClick(object sender, EventArgs e)
        {
            cSenha2.Visible = false;
            senhaTextBox.UseSystemPasswordChar = false;
        }
        private void cSenha1_MouseClick(object sender, EventArgs e)
        {
            cSenha2.Visible = true;
            senhaTextBox.UseSystemPasswordChar = true;
        }
    }
}
