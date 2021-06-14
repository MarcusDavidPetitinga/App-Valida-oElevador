using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ValidacaoElevador.Entity;

namespace ValidacaoElevador.Forms
{
    public partial class FormTesteCargaVelocidade : Form
    {
        public FormTesteCargaVelocidade()
        {
            InitializeComponent();
        }



        private void FormTesteCargaVelocidade_Load(object sender, EventArgs e)
        {


        }


       
        public static string Andares;
        public static string CargaMaxima;
        public static string VelocidadeMaxima;


        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ConexaoEBusca();
                validacao();
                textData.Text = DateTime.Now.ToString();

               

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Erro" + ex);

            }
        }

        public static string k = alfanumericoAleatorio();
        public static string alfanumericoAleatorio(int tamanho = 4)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        public static Random gerador1 = new Random();
        public static Random gerador2 = new Random();
        public static Random gerador3 = new Random();
        public static Random gerador4 = new Random();


        public static int g1 = gerador1.Next(600);
        public static int g2 = gerador2.Next(3);
        public static int g3 = gerador3.Next(2);
        public static int g4 = gerador4.Next(2);

        public void ConexaoEBusca()
        {

            string stringConexao = @"Server = localhost\SQLEXPRESS; Database = ValidacaoElevador; Trusted_Connection = True;";
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();
            string stringConsulta = $"select *from CadastrarElevador where NSerie='{textNSerie.Text}';";

            SqlCommand comandoConsultar = new SqlCommand(stringConsulta, conexao);
            comandoConsultar.CommandType = CommandType.Text;
            SqlDataReader dataReader;
            dataReader = comandoConsultar.ExecuteReader();
            dataReader.Read();


            textAndares.Text = dataReader.GetInt32(2).ToString();
            textCargaMax.Text = dataReader.GetDecimal(3).ToString();
            textVelMax.Text = dataReader.GetDecimal(4).ToString();
            CargaMaxima = dataReader.GetDecimal(3).ToString();
            VelocidadeMaxima = dataReader.GetDecimal(4).ToString();
        }
        public void validacao()
        {

            TesteSensores.TestarCarga();
            if (TesteSensores.TSensorCarga == true) { textSensorCarga.Text = $"Carga ok ({g1}Kg)"; } else { textSensorCarga.Text = $"Excesso de carga ({g1}kg)"; }

            TesteSensores.TestarVelocidade();

            if (TesteSensores.TSensorVelocidade == true) { textSensorVelocidade.Text = $"Velocidade ok ({g2}m/s)"; } else { textSensorVelocidade.Text = $"Excesso de velocidade ({g2}m/s)"; }

            TesteSensores.TestarPorta();
            if (TesteSensores.TSensorStatusPorta == true) { textSensorPorta.Text = $"Porta ok "; } else { textSensorPorta.Text = $"Porta com defeito  "; }
            TesteSensores.TestarStop();
            if (TesteSensores.TSensorStop == true) { textSensorStop.Text = $"Stop ok "; } else { textSensorStop.Text = $"Stop com defeito  "; }
            TesteSensores.TestarBotoes();
            if (TesteSensores.TSensorBotoes == true) { textSensorBotoes.Text = $"Botões ok! Executando somente um botão ({TesteSensores.botoes}) "; } else { textSensorBotoes.Text = "Bug! Executando vários botões "; }

            if (TesteSensores.TSensorCarga == false || TesteSensores.TSensorVelocidade == false || TesteSensores.TSensorStatusPorta == false || TesteSensores.TSensorStop == false || TesteSensores.TSensorBotoes == false) { textStatus.Text = "Manutenção"; } else { textStatus.Text = "Aprovado"; }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void butSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show(butSair.Text);
            Application.Exit();
        }


        public SqlConnection conect = new SqlConnection(@"Server = localhost\SQLEXPRESS; Database = ValidacaoElevador; Trusted_Connection = True;");
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            gerarRelatorio();
        }
        public String[] getFildsValue()
        {
            String[] valores = new String[3];

            valores[0] = textNSerie.Text;
           

            return valores;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
           
            if (pageSetupDialog1.ShowDialog() != DialogResult.Cancel)
            {
                if (printDialog1.ShowDialog() != DialogResult.Cancel) { 
           printDocument.Print();
            
            
           }

                
            }
               

        }
        public void gerarRelatorio() {
            string stringInsecao = $"insert into TesteElevadorVE(NSerie,DataTeste,Andares,CargaMax,VelocidadeMax,SensorCarga,SensorVelocidade,SensorStop,SensorPorta,SensorBotoes,StatusGeral)values(@NSerie,@DataTeste,@Andares,@CargaMax,@VelocidadeMax,@SensorCarga,@SensorVelocidade,@SensorStop,@SensorPorta,@SensorBotoes,@StatusGeral)";

            try
            {
                SqlCommand comando = new SqlCommand(stringInsecao, conect);

                comando.Parameters.Add(new SqlParameter("@NSerie", this.textNSerie.Text));
                comando.Parameters.Add(new SqlParameter("@DataTeste", this.textData.Text));
                comando.Parameters.Add(new SqlParameter("@Andares", this.textAndares.Text));
                comando.Parameters.Add(new SqlParameter("@CargaMax", this.textCargaMax.Text));
                comando.Parameters.Add(new SqlParameter("@VelocidadeMax", this.textVelMax.Text));
                comando.Parameters.Add(new SqlParameter("@SensorCarga", this.textSensorCarga.Text));
                comando.Parameters.Add(new SqlParameter("@SensorVelocidade", this.textSensorVelocidade.Text));
                comando.Parameters.Add(new SqlParameter("@SensorStop", this.textSensorStop.Text));
                comando.Parameters.Add(new SqlParameter("@SensorPorta", this.textSensorPorta.Text));
                comando.Parameters.Add(new SqlParameter("@SensorBotoes", this.textSensorBotoes.Text));
                comando.Parameters.Add(new SqlParameter("@StatusGeral", this.textStatus.Text));
                conect.Open();

                comando.ExecuteNonQuery();

                caixaRelatorio.Text = $"Relatório Teste Elevador \n\nNúmero de série:{textNSerie.Text}\nData do teste: {textData.Text}\n\n " +
                      $"Andares: {textAndares.Text}\nCarga máxima cadastrada:{textCargaMax.Text} kg,  carga utilizada {g1}Ks\nVelocidade máxima cadastrada: {textVelMax.Text}m/s, velocidade atinjida {g2}m/s" +
                      $"\nStatus do sensor de stop: {textSensorStop.Text} \nStatus do sensor de porta: {textSensorPorta.Text}\nStatus dos botões: {textSensorBotoes.Text}, \nBotões pressionados:{k}, botão executado:{TesteSensores.botoes})" +
                      $"\n\nStatus geral conclusão: {textStatus.Text}";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao gerar relatório" + ex);
            }
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txt = caixaRelatorio.Text;
            Font letra = new Font("Arial", 14, FontStyle.Regular);
            Brush pincel = new SolidBrush(Color.Black);
            e.Graphics.DrawString(txt, letra, pincel, new PointF(20, 20));

        }
    }
}
          
            
                   
        

    

