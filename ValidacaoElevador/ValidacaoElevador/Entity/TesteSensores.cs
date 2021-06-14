using System;
using ValidacaoElevador.Forms;

namespace ValidacaoElevador.Entity
{
    public  class TesteSensores
    {
        public static int SensorCarga = SimuladorDeDadosObtidos.simuladorSensorCarga;
        public static int SensorVelocidade = SimuladorDeDadosObtidos.simuladorSensorVelocidade;
        public static  int SensorStop = SimuladorDeDadosObtidos.simuladorSensorStop;
        public static  int SensorStatusPorta =SimuladorDeDadosObtidos.simuladorSensorStatusPorta;
        public  static string Botoes=SimuladorDeDadosObtidos.simuladorBotoes;
       

        public static bool TSensorCarga = false;
        public static bool TSensorVelocidade = false;
        public static bool TSensorStop = false;
        public static bool TSensorStatusPorta = false;
        public static bool TSensorBotoes = false;

        public static string botoes=Botoes.Substring(0,1);

        
      
        public static void TestarCarga() {
            if (SensorCarga <= Int32.Parse(FormTesteCargaVelocidade.CargaMaxima)) {
                TSensorCarga = true;
            }
           
        }

        public static void TestarVelocidade()
        {
            if (SensorVelocidade<=Int32.Parse(FormTesteCargaVelocidade.VelocidadeMaxima))
            {
                TSensorVelocidade = true;
            }
          

        }
        public static void TestarStop()
        {
            if (SensorStop == 0)
            {
                TSensorStop = true;
            }

        }
        public static void TestarPorta()
        {
            if (SensorStatusPorta == 0)
            {
                TSensorStatusPorta = true;
            }

        }
        public static void TestarBotoes()
        {
            if (botoes.Length == 1)
            {
                TSensorBotoes = true;
            }

        }



    }
}
