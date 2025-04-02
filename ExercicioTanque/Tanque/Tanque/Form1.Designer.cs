namespace Tanque
{
    partial class Form1
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
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAbrirValvula = new System.Windows.Forms.Button();
            this.btnFecharValvula = new System.Windows.Forms.Button();
            this.progressBarNivel = new System.Windows.Forms.ProgressBar();
            this.btnEmergencia = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.lblNivelMaximo = new System.Windows.Forms.Label();
            this.lblNivelMinimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblData.AutoEllipsis = true;
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblData.Location = new System.Drawing.Point(145, 45);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(100, 23);
            this.lblData.TabIndex = 0;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblData.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(515, 54);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(130, 14);
            this.lblHora.TabIndex = 1;
            this.lblHora.EnabledChanged += new System.EventHandler(this.timer1_Tick);
            this.lblHora.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(196, 460);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(164, 84);
            this.btnLigar.TabIndex = 2;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(605, 460);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(171, 84);
            this.btnDesligar.TabIndex = 3;
            this.btnDesligar.Text = "DESLIGAR";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(403, 460);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(156, 84);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAbrirValvula
            // 
            this.btnAbrirValvula.Location = new System.Drawing.Point(74, 166);
            this.btnAbrirValvula.Name = "btnAbrirValvula";
            this.btnAbrirValvula.Size = new System.Drawing.Size(138, 42);
            this.btnAbrirValvula.TabIndex = 5;
            this.btnAbrirValvula.Text = "Abrir Valvula";
            this.btnAbrirValvula.UseVisualStyleBackColor = true;
            this.btnAbrirValvula.Click += new System.EventHandler(this.btnAbrirValvula_Click);
            // 
            // btnFecharValvula
            // 
            this.btnFecharValvula.Location = new System.Drawing.Point(74, 320);
            this.btnFecharValvula.Name = "btnFecharValvula";
            this.btnFecharValvula.Size = new System.Drawing.Size(138, 33);
            this.btnFecharValvula.TabIndex = 6;
            this.btnFecharValvula.Text = "Fechar Valvula";
            this.btnFecharValvula.UseVisualStyleBackColor = true;
            this.btnFecharValvula.Click += new System.EventHandler(this.btnFecharValvula_Click);
            // 
            // progressBarNivel
            // 
            this.progressBarNivel.Location = new System.Drawing.Point(724, 163);
            this.progressBarNivel.Name = "progressBarNivel";
            this.progressBarNivel.Size = new System.Drawing.Size(148, 54);
            this.progressBarNivel.TabIndex = 9;
            this.progressBarNivel.Value = 50;
            // 
            // btnEmergencia
            // 
            this.btnEmergencia.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnEmergencia.Location = new System.Drawing.Point(94, 214);
            this.btnEmergencia.Name = "btnEmergencia";
            this.btnEmergencia.Size = new System.Drawing.Size(95, 100);
            this.btnEmergencia.TabIndex = 10;
            this.btnEmergencia.Text = "Emergencia";
            this.btnEmergencia.UseVisualStyleBackColor = false;
            this.btnEmergencia.Click += new System.EventHandler(this.btnEmergencia_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 214);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 100);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(195, 214);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(75, 100);
            this.btnNotas.TabIndex = 12;
            this.btnNotas.Text = "Notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // lblNivelMaximo
            // 
            this.lblNivelMaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNivelMaximo.Enabled = false;
            this.lblNivelMaximo.Image = global::Tanque.Properties.Resources.Tanque_de_Mistura_On2;
            this.lblNivelMaximo.ImageKey = "(nenhum/a)";
            this.lblNivelMaximo.Location = new System.Drawing.Point(363, 132);
            this.lblNivelMaximo.Name = "lblNivelMaximo";
            this.lblNivelMaximo.Size = new System.Drawing.Size(138, 205);
            this.lblNivelMaximo.TabIndex = 8;
            this.lblNivelMaximo.Text = "Nivel Maximo";
            this.lblNivelMaximo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblNivelMaximo.Click += new System.EventHandler(this.lblNivelMaximo_Click);
            // 
            // lblNivelMinimo
            // 
            this.lblNivelMinimo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblNivelMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNivelMinimo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNivelMinimo.ForeColor = System.Drawing.Color.Black;
            this.lblNivelMinimo.Image = global::Tanque.Properties.Resources.Tanque_de_Mistura_Off2;
            this.lblNivelMinimo.Location = new System.Drawing.Point(366, 131);
            this.lblNivelMinimo.Name = "lblNivelMinimo";
            this.lblNivelMinimo.Size = new System.Drawing.Size(135, 200);
            this.lblNivelMinimo.TabIndex = 7;
            this.lblNivelMinimo.Text = "Nivel Minimo";
            this.lblNivelMinimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 681);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnEmergencia);
            this.Controls.Add(this.progressBarNivel);
            this.Controls.Add(this.lblNivelMaximo);
            this.Controls.Add(this.lblNivelMinimo);
            this.Controls.Add(this.btnFecharValvula);
            this.Controls.Add(this.btnAbrirValvula);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAbrirValvula;
        private System.Windows.Forms.Button btnFecharValvula;
        private System.Windows.Forms.Label lblNivelMinimo;
        private System.Windows.Forms.Label lblNivelMaximo;
        private System.Windows.Forms.ProgressBar progressBarNivel;
        private System.Windows.Forms.Button btnEmergencia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNotas;
    }
}

