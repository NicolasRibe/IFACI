using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Temp_Arduino
{
    public partial class Termometro : Form
    {
        public Termometro()
        {
            InitializeComponent();//inicializa componentes do formulario 



        }

        private void leTemp(object sender, EventArgs e) 
        {
            byte[] dados = new byte[2]; //buffer para dados (nao ultilizados)
            string valor;

            valor = serialPortCOM.ReadExisting();//le todos os dados recebidos pelka porta serial

            if (valor != "")//se recebeu dados 
            
            {
                thermControl1.UpdateControl(Convert.ToInt32(valor));// atualiza controle de temperatura
                
                //limpa buffer
                serialPortCOM.DiscardInBuffer();
                serialPortCOM.DiscardOutBuffer();
            
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPorta.Text != "")//verifica se foi informada uma porta 
                serialPortCOM.PortName = txtPorta.Text;// CONFI.a porta serial
            if (!serialPortCOM.IsOpen)
                serialPortCOM.Open();
        }

        private void thermControl1_Load(object sender, EventArgs e)
        {
   
        }

        private void serialPortCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(leTemp));
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (serialPortCOM.IsOpen)
                serialPortCOM.Close();//fecha a comunicação 

            Application.Exit();//Encerra a aplicação 

        }
    }
}
