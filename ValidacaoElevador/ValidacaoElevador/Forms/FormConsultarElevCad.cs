using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ValidacaoElevador.Forms
{
    public partial class FormConsultarElevCad : Form
    {
        public FormConsultarElevCad()
        {
            InitializeComponent();
        }

        public SqlConnection conexao = new SqlConnection(@"Server = localhost\SQLEXPRESS; Database = ValidacaoElevador; Trusted_Connection = True;");

        private void RBConsultList_CheckedChanged(object sender, EventArgs e)
        {
            consultarElevador();
        }

        private void btnconsultElevCadVoltar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void RBConsulNSerie_CheckedChanged(object sender, EventArgs e)
        {
            consultarpnserie();
            }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimirTabela();
        }
        public void consultarpnserie() {
            string stringConsultaElevnSerie = $"select* from cadastrarElevador where Nserie={textConsultaNSerie.Text}";
            try
            {
                conexao.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(stringConsultaElevnSerie, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Digite o número de série");
                FormConsultarElevCad formConsultarElevcad = new FormConsultarElevCad();
                formConsultarElevcad.Show();
                this.Hide();
            }
            conexao.Close();
        }
        public void imprimirTabela() {  int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
        }
        public void consultarElevador() {
            try
            {
                conexao.Open();

                string stringConsultaListaElevcadast = $"select *from CadastrarElevador;";

                using (SqlDataAdapter da = new SqlDataAdapter(stringConsultaListaElevcadast, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {

                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                }



            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao consultar");
            }
            conexao.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    } 
