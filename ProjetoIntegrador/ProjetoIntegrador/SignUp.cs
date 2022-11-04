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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();// tooltip para mostrar mensagem quando posição do mouse em cima de botão
            toolTip1.AutoPopDelay = 1500;
            toolTip1.InitialDelay = 400;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.cPFMaskedTextBox, "Apenas números");
            toolTip1.SetToolTip(this.emailTextBox, "Máximo 10 digitos");
            toolTip1.SetToolTip(this.nomeTextBox, "Nome completo");
            toolTip1.SetToolTip(this.senhaTextBox, "Digite seu e-mail");


        }
        /* Movimentar aplicativo na área de trabalho */
        private bool mover;
        private int cX, cY;

        public object TableLoginBindingSource { get; private set; }

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

        private void lbEntrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var entrar = new SignIn();
            this.Hide();
            entrar.ShowDialog();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            cPFMaskedTextBox.Text = "";
            nomeTextBox.Text = "";
            senhaTextBox.Text = "";
            emailTextBox.Text = "";
            cbTermos.Checked = false;
            
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            LoginDataSetTableAdapters.TableLoginTableAdapter Signup = new LoginDataSetTableAdapters.TableLoginTableAdapter();

            cPFMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (cPFMaskedTextBox.Text == "")
            {
                MessageBox.Show("Informe um CPF!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
            else
            {
                if (ValidarCPF.validarCPF(cPFMaskedTextBox.Text))
                {
                    cPFMaskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                    try
                    {
                        if (senhaTextBox.TextLength > 10)
                        {
                            MessageBox.Show("A senha deve conter no máximo 10 digitos");
                        }
                        else if (cbTermos.Checked == false)
                        {
                            MessageBox.Show("Necessário concordar com os termos e condições!");
                        }
                        else
                        {
                            Signup.inserir_alterar_Cadastro(cPFMaskedTextBox.Text, nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, 1);
                            MessageBox.Show("Cadastrado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            /*this.Validate();
                            this.TableLoginBindingSource.EndEdit();
                            this.TableLoginAdapterManager.UpdateAll(this.LoginDataSet);*/

                            var entrar = new SignIn();
                            this.Hide();
                            entrar.ShowDialog();
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir cadastro\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Informe um CPF válido!", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var telainicial = new TelaInicial();
            this.Hide();
            telainicial.ShowDialog();
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
