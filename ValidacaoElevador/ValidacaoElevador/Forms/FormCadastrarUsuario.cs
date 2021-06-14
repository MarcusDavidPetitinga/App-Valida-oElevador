using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ValidacaoElevador.Forms;

namespace ValidacaoElevador
{
    public partial class FormCadastrarUsuario : Form
    {
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        }
       public SqlConnection conexao = new SqlConnection(@"Server = localhost\SQLEXPRESS; Database = ValidacaoElevador; Trusted_Connection = True;");
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          
            string stringInsecao = $"insert into CadastrarUsuarioVE(Nome,Senha,Email)values(@nome,@senha,@email)";



            try
            {
                if (textCadSenha.Text.Equals(textConfSenha.Text) && ((textCadAutAdm.Text).ToString()).Equals("pO38i*Jnç2#ed"))
                    {
                   
                    SqlCommand comando = new SqlCommand(stringInsecao, conexao);
               
                    comando.Parameters.Add(new SqlParameter("@nome", this.textCadNome.Text));
                    comando.Parameters.Add(new SqlParameter("@senha", this.textCadSenha.Text));
                    comando.Parameters.Add(new SqlParameter("@email", this.textCadEmail.Text));
                    conexao.Open();

                    comando.ExecuteNonQuery();

                  
                    MessageBox.Show("Cadastro criado com sucesso!"); 
                   this.Hide();
                   FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
               else { MessageBox.Show("Dados ou senha de autenticação inconsistentes!"); }
            }
            catch (SqlException ) {
                MessageBox.Show("Erro ao cadastrar!");
            }conexao.Close();
          

        }

        private void butVoltar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }
    }
} 
