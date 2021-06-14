using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ValidacaoElevador.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }
   
       
     
         private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {


           
            
        }

        
        private void btnMenuSeguir_Click(object sender, EventArgs e)
        {
            
                      
        }

        private void MenuRBSair_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(MenuRBSair.Text);
            Application.Exit();
        }

    
        private void RBListElevCadast_CheckedChanged(object sender, EventArgs e)
        {
            FormConsultarElevCad consultarElevador = new  FormConsultarElevCad();

            MessageBox.Show(RBListElevCadast.Text);
            consultarElevador.Show();
            this.Hide();
        }

        private void btnMenuSeguir_Click_1(object sender, EventArgs e)
        {
            FormCadastrarElevador cadastrarElevador = new FormCadastrarElevador();

            MessageBox.Show(MenuRBCadastrar.Text);
            cadastrarElevador.Show();
            this.Hide();

        }

        private void RBTesteCargaVel_CheckedChanged(object sender, EventArgs e)
        {
            FormTesteCargaVelocidade formTesteCargaVelocidade = new FormTesteCargaVelocidade();
            MessageBox.Show(RBTesteCargaVel.Text);
            formTesteCargaVelocidade.Show();
            this.Hide();
        }
    }
    }

