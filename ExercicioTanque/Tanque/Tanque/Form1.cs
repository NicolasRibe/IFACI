using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Tanque
{
    public partial class Form1 : Form

      
    {



        public Form1()
        {
            InitializeComponent();
            

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            lblData.Visible=true;
            lblHora.Visible=true;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema iniciado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            lblNivelMaximo.Visible=true;
            lblNivelMaximo.Enabled=true;
            lblNivelMinimo.Visible=false;
            lblNivelMinimo.Enabled=false;

           
            
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema desligado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblNivelMaximo.Visible = false;
            lblNivelMaximo.Enabled = false;
            lblNivelMinimo.Visible = true;
            lblNivelMinimo.Enabled = true;



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAbrirValvula_Click(object sender, EventArgs e)
        {
            if (progressBarNivel.Value < progressBarNivel.Maximum)
            {
                progressBarNivel.Value += 10;
            }

            // Se atingir o nível máximo, mostra a imagem e oculta a do mínimo
            if (progressBarNivel.Value == progressBarNivel.Maximum)
            {
                lblNivelMaximo.Visible = true;
                lblNivelMinimo.Visible = false;
            }
        }
        private void btnFecharValvula_Click(object sender, EventArgs e)
        {
            if (progressBarNivel.Value > progressBarNivel.Minimum) {
                progressBarNivel.Value -= 10;
            }
            if (progressBarNivel.Value == progressBarNivel.Minimum)
            {
                lblNivelMaximo.Visible = false;
                lblNivelMinimo.Visible = true;
            }

        }

        private void btnEmergencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EMERGÊNCIA! Todas as válvulas foram fechadas!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Desativar válvulas
            btnAbrirValvula.Enabled = false;
            btnFecharValvula.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void lblNivelMaximo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
