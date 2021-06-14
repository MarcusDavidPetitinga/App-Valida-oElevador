using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ValidacaoElevador.Forms;

namespace ValidacaoElevador
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public SqlConnection conexao = new SqlConnection(@"Server = localhost\SQLEXPRESS; Database = ValidacaoElevador; Trusted_Connection = True;");

        private void button1_Click(object sender, EventArgs e)
        {
            string stringDeComando = $"select *from CadastrarUsuarioVE where Nome='{textBox1.Text}'and Senha='{textBox2.Text}';";

            try
            {
                
                conexao.Open();

                SqlCommand comandoConsultar = new SqlCommand(stringDeComando, conexao);
                comandoConsultar.CommandType = CommandType.Text;
                SqlDataReader dataReader;
                dataReader = comandoConsultar.ExecuteReader();
                dataReader.Read();
               

                if (dataReader.HasRows)
                {
                    this.Hide();
                   
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                   
                }
                else {
                    MessageBox.Show("Usuário não cadastrado!");
                    this.Hide();
                    FormCadastrarUsuario formCadastrarUsuario = new FormCadastrarUsuario();
                    formCadastrarUsuario.Show();
                    dataReader.Close();
                }

              
            }
            
             catch (SqlException )
                {
                MessageBox.Show("Erro ao conectar com o banco de dados!");

            }
            finally
            {
               conexao.Close();
                
            }


        }
              
    } 
}
