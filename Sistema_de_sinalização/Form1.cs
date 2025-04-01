using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sistema_de_sinalização
{
    public partial class Form1 : Form
    {
        int timerRua = 0;
        int timerAvenida = 0;
        int timerEmergencia = 0;
        
        public Form1()
        {
            InitializeComponent();

            pbAvenidaVerde.Visible = true;
            pbAvenidaVermelho.Visible = false;
            pbAvenidaAmarelo.Visible = false;

            pbRuaVermelho.Visible = true;
            pbRuaAmarelo.Visible = false;
            pbRuaVerde.Visible = false;
           
        }

        private void botaoStart_Click(object sender, EventArgs e)
        {
            timerAvenidaVerde.Enabled = true;
            timerRuaVermelho.Enabled = true;
            timerLabel.Enabled = true;
        }

        private void timerAvenidaVerde_Tick(object sender, EventArgs e)
        {
            timerAvenida++;

            if (timerAvenida == 2) {

                timerAvenidaVerde.Enabled=false;
                pbAvenidaVerde.Visible= false;
                pbAvenidaAmarelo.Visible = true;
                timerAvenidaAmarelo.Enabled=true;
                timerAvenida = 0;

            }
        }

        private void timerAvenidaAmarelo_Tick(object sender, EventArgs e)
        {
            timerAvenida++;

            if (timerAvenida == 1) {
                timerAvenidaAmarelo.Enabled = false;
                pbAvenidaAmarelo.Visible= false;
                pbAvenidaVermelho.Visible= true;
                timerAvenidaVermelho.Enabled=true;
                timerAvenida= 0;
            
            }
        }

        private void timerAvenidaVermelho_Tick(object sender, EventArgs e)
        {
            timerAvenida++;

            if (timerAvenida == 3) {

                timerAvenidaVermelho.Enabled = false;
                pbAvenidaVermelho.Visible = false;
                pbAvenidaVerde.Visible = true;
                timerAvenidaVerde.Enabled = true;   

                timerAvenida= 0;
            
            }
        }

        private void timerRuaVermelho_Tick(object sender, EventArgs e)
        {
            timerRua++;

            if (timerRua == 3)
            {

                timerRuaVermelho.Enabled = false;
                pbRuaVermelho.Visible = false;
                pbRuaVerde.Visible = true;
                timerRuaVerde.Enabled = true;
                timerRua = 0;

            }
        }

        private void timerRuaVerde_Tick(object sender, EventArgs e)
        {
            timerRua++;

            if (timerRua == 2) 
            {
                timerRuaVerde.Enabled= false;
                pbRuaVerde.Visible= false;
                pbRuaAmarelo.Visible= true;
                timerRuaAmarelo.Enabled= true;
                timerRua= 0;


            }
        }

        private void timerRuaAmarelo_Tick(object sender, EventArgs e)
        {
            timerRua++;

            if (timerRua == 1) { 
            
                timerRuaAmarelo.Enabled = false;
                pbRuaAmarelo.Visible = false;
                pbRuaVermelho.Visible= true;
                timerRuaVermelho.Enabled= true;
                timerRua = 0;
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timerLabel_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pbAvenidaVerde.Visible = true;
            pbAvenidaVermelho.Visible = false;
            pbAvenidaAmarelo.Visible = false;

            pbRuaVermelho.Visible = true;
            pbRuaAmarelo.Visible = false;
            pbRuaVerde.Visible = false;

            timerAvenidaAmarelo.Enabled = false;
            timerAvenidaVerde.Enabled = false;
            timerAvenidaVermelho.Enabled = false;

            timerRuaAmarelo.Enabled= false;
            timerRuaVerde.Enabled= false;
            timerRuaVermelho.Enabled= false;

            timerRua = 0;
            timerAvenida = 0;
            timerLabel.Enabled = false;

            label1.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerAvenida = 0;
            timerRua = 0;
           
            timerAvenidaVerde.Enabled = false;
            timerAvenidaVermelho.Enabled = false;
            timerAvenidaAmarelo.Enabled = false;

            timerRuaVerde.Enabled = false;
            timerRuaVermelho.Enabled = false;
            timerRuaAmarelo.Enabled = false;

            pbAvenidaVerde.Visible = false;
            pbAvenidaVermelho.Visible = false;
            pbAvenidaAmarelo.Visible = true;

            pbRuaVermelho.Visible = false;
            pbRuaAmarelo.Visible = true;
            pbRuaVerde.Visible = false;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timerEmergencia++;

            if (timerEmergencia == 5)
            {

                timerRua = 0;
                timerAvenida = 0;
                timerEmergencia = 0;
                timerAvenidaVerde.Enabled = true;
                timerRuaVermelho.Enabled = true;
                timerLabel.Enabled = true;
                timer1.Enabled=false;
                pbAvenidaVerde.Visible=true;
                pbRuaVermelho.Visible=true;



            }

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Process.Start("https://www.policiacivil.sp.gov.br/portal/faces/pages_home?_afrLoop=7504262867208&_afrWindowMode=0&_afrWindowId=null#!%40%40%3F_afrWindowId%3Dnull%26_afrLoop%3D7504262867208%26_afrWindowMode%3D0%26_adf.ctrl-state%3D1bklyug3ib_4");
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            Process.Start("https://www.corpodebombeiros.sp.gov.br/#/");
        }
    }
}
