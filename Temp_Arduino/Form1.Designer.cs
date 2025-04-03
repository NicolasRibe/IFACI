namespace Temp_Arduino
{
    partial class Termometro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Termometro));
            this.btIniciar = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.thermControl1 = new ThermometerControl.ThermControl();
            this.serialPortCOM = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.LightGray;
            this.btIniciar.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.Location = new System.Drawing.Point(71, 441);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(117, 81);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Tag = "";
            this.btIniciar.Text = "INICIAR";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.LightGray;
            this.btFinalizar.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Location = new System.Drawing.Point(252, 441);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(117, 81);
            this.btFinalizar.TabIndex = 2;
            this.btFinalizar.Text = "FINALIZAR";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // lblPort
            // 
            this.lblPort.BackColor = System.Drawing.SystemColors.Menu;
            this.lblPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPort.Location = new System.Drawing.Point(71, 392);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(117, 20);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "PORTA_COM";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPorta
            // 
            this.txtPorta.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPorta.Location = new System.Drawing.Point(194, 392);
            this.txtPorta.Multiline = true;
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(175, 20);
            this.txtPorta.TabIndex = 3;
            // 
            // thermControl1
            // 
            this.thermControl1.Location = new System.Drawing.Point(123, 12);
            this.thermControl1.MinimumSize = new System.Drawing.Size(180, 315);
            this.thermControl1.Name = "thermControl1";
            this.thermControl1.Size = new System.Drawing.Size(183, 349);
            this.thermControl1.TabIndex = 4;
            this.thermControl1.Value = 0;
            this.thermControl1.Load += new System.EventHandler(this.thermControl1_Load);
            // 
            // serialPortCOM
            // 
            this.serialPortCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortCOM_DataReceived);
            // 
            // Termometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(420, 740);
            this.Controls.Add(this.thermControl1);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Termometro";
            this.Text = "Termometro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPorta;
        private ThermometerControl.ThermControl thermControl1;
        private System.IO.Ports.SerialPort serialPortCOM;
        private System.Windows.Forms.Timer timer1;
    }
}

