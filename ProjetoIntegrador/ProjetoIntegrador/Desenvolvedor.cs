using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class Desenvolvedor : Form
    {
        public Desenvolvedor()
        {
            InitializeComponent();
        }

        LoginDataSet.TableLoginDataTable cadastroSignup = new LoginDataSet.TableLoginDataTable();
        LoginDataSetTableAdapters.TableLoginTableAdapter cadastro = new LoginDataSetTableAdapters.TableLoginTableAdapter();

        LoginDataSetTableAdapters.TableLoginTableAdapter Signup = new LoginDataSetTableAdapters.TableLoginTableAdapter();

        private void Desenvolvedor_Load(object sender, EventArgs e)
        {
            table1DataGridView.Visible = false;
            btnOK.Visible = false;


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var logindev = new LoginDeveloper();
            this.Hide();
            logindev.ShowDialog();
        }
        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            btnVoltar.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            btnVoltar.BackColor = Color.DarkGray;
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


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            

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
                        else
                        {
                            Signup.inserir_alterar_Cadastro(cPFMaskedTextBox.Text, nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, 1);
                            MessageBox.Show("Cadastrado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           /* this.Validate();
                            this.table1BindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.signUpDataSet);*/

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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linha;
                linha = table1DataGridView.CurrentRow;
                cPFMaskedTextBox.Text = linha.Cells["CPF"].Value.ToString();
                nomeTextBox.Text = linha.Cells["Nome"].Value.ToString();
                emailTextBox.Text = linha.Cells["Email"].Value.ToString();
                senhaTextBox.Text = linha.Cells["Senha"].Value.ToString();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um cadastro\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pesquisaTextBox_TextChanged(object sender, EventArgs e)
        {

            // VERIFICAR SE EXISTE O CPF OU O NOME
            try
            {

                string conectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LUCAS\Desktop\Projetos\ProjetoIntegradorV2\ProjetoIntegrador\SignUp.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(conectionString);
                con.Open();

                string consulta = "SELECT CPF, Nome FROM Table1 WHERE CPF = @CPF OR Nome = @Nome";
               

                SqlCommand cmd = new SqlCommand(consulta, con);
               

                //Passo o parametro
                cmd.Parameters.AddWithValue("@CPF", pesquisaTextBox.Text);
                cmd.Parameters.AddWithValue("@Nome", pesquisaTextBox.Text);

                SqlDataReader read = cmd.ExecuteReader();
                
                if (rbCPF.Checked == true)
                {
                    pesquisaTextBox.MaxLength = 11;
                    if (pesquisaTextBox.TextLength != 11)
                    {
                        
                        table1DataGridView.Visible = false;
                        btnOK.Visible = false;

                    }
                    else
                    {
                        //SE EXISTIR ELE ENTRA NO IF
                        if (read.Read())
                        {
                            MessageBox.Show("CPF existente");

                            btnOK.Visible = true;

                            cadastro.FillByBuscaCPF(cadastroSignup, pesquisaTextBox.Text);
                            table1DataGridView.DataSource = cadastroSignup;

                          
                        }
                        //SENÃO NÃO ENTRA
                        else
                        {
                            MessageBox.Show("CPF não existente");
                        }
                        
                    }
                    
                }
                
                
                else if (rbNome.Checked == true)
                {
                    if(pesquisaTextBox.Text != "")
                    {
                        //SE EXISTIR ELE ENTRA NO IF
                        if (read.Read())
                        {
                            MessageBox.Show("Nome existente");

                            btnOK.Visible = true;

                            cadastro.FillByBuscaNome(cadastroSignup, pesquisaTextBox.Text);
                            table1DataGridView.DataSource = cadastroSignup;


                        }
                                                                   
                    }
                    else
                    {
                        MessageBox.Show("Nome não digitado ou incorreto");
                        table1DataGridView.Visible = false;
                        btnOK.Visible = false;
                    }

                    

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao localizar dados do cadastro\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Signup.inserir_alterar_Cadastro(cPFMaskedTextBox.Text, nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, 2);
                MessageBox.Show("Dados atualizados!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Cadastro\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cadastro?", "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Signup.ExcluirCadastro(cPFMaskedTextBox.Text);
                    cPFMaskedTextBox.Text = "";
                    nomeTextBox.Text = "";
                    emailTextBox.Text = "";
                    senhaTextBox.Text = "";
                    MessageBox.Show("Cadastro excluído", "Confirmação de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao excluir cadastro!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cadastro.FillByBuscaTodos(cadastroSignup);
            table1DataGridView.DataSource = cadastroSignup;

            table1DataGridView.Visible = true;

            
        }

        private void table1DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = this.table1DataGridView.Rows[e.RowIndex];
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

        private void lbEcolog_MouseEnter(object sender, EventArgs e)
        {
            lbEcolog.ForeColor = Color.LimeGreen;
        }
        private void lbEcolog_MouseLeave(object sender, EventArgs e)
        {
            lbEcolog.ForeColor = Color.FromArgb(0, 64, 0);
        }
    }
}
