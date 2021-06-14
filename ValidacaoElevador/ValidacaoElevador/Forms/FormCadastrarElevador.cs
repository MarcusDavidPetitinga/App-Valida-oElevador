using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ValidacaoElevador.Forms
{
    public partial class FormCadastrarElevador : Form
    {
        public FormCadastrarElevador()
        {
            InitializeComponent();
        }

        private void ButcadElevVoltar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void ButcadElevSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encerrar o aplicativo?");
            Application.Exit();
        }

        public SqlConnection conexao = new SqlConnection(@"Server = localhost\SQLEXPRESS; Database = ValidacaoElevador; Trusted_Connection = True;");
        private void ButcadElevCadastrar_Click(object sender, EventArgs e)
        {
            string stringInsecao = $"insert into CadastrarElevador(NSerie,Andares,CargaMax,VelocidadeMax)values(@NSerie,@Andares,@CargaMax,@VelocidadeMax)";



            try
            {
                if ((!textCadElevNSerie.Text.Equals(null)) && (!textCadElevAndares.Text.Equals(null)) && (!textCadElevCargMax.Text.Equals(null)) && (!textCadElevVelMax.Text.Equals(null))) 
                {

                    SqlCommand comando = new SqlCommand(stringInsecao, conexao);

                    comando.Parameters.Add(new SqlParameter("@NSerie", this.textCadElevNSerie.Text));
                    comando.Parameters.Add(new SqlParameter("@Andares", this.textCadElevAndares.Text));
                    comando.Parameters.Add(new SqlParameter("@CargaMax", this.textCadElevCargMax.Text));
                    comando.Parameters.Add(new SqlParameter("@VelocidadeMax", this.textCadElevVelMax.Text));
                    conexao.Open();

                    comando.ExecuteNonQuery();


                    MessageBox.Show("Cadastro criado com sucesso!");
                    MessageBox.Show("Voltar ao menu inicial.");

                    this.Hide();
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                }
                else { MessageBox.Show("Dados ou senha de autenticação inconsistentes!"); }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
            conexao.Close();

        
        }

        private void ButCadElevGerar_Click(object sender, EventArgs e)
        {
           Random gerarNSerie = new Random();
            textCadElevNSerie.Text = gerarNSerie.Next().ToString();
        }

        private void textCadElevAndares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {

                e.Handled = true;
            }
        }

        private void textCadElevCargMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {

                e.Handled = true;
            }

        }
       private void textCadElevVelMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {

                e.Handled = true;
            }
        } 
        private void textCadElevNSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
        {

            e.Handled = true;
        }
        }
                
       

        public void FormCadastrarElevador_Load(object sender, EventArgs e)
        {

        }
    }
}
