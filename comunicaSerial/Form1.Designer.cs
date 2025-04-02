namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.txtReceber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 375);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerCOM
            // 
            this.timerCOM.Enabled = true;
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "ComPortas";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // txtEnviar
            // 
            this.txtEnviar.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtEnviar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnviar.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEnviar.Location = new System.Drawing.Point(45, 92);
            this.txtEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnviar.Multiline = true;
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnviar.Size = new System.Drawing.Size(461, 256);
            this.txtEnviar.TabIndex = 4;
            this.txtEnviar.Click += new System.EventHandler(this.txtEnviar_TextChanged);
            this.txtEnviar.TextChanged += new System.EventHandler(this.txtEnviar_TextChanged);
            // 
            // txtReceber
            // 
            this.txtReceber.AcceptsReturn = true;
            this.txtReceber.AllowDrop = true;
            this.txtReceber.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtReceber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReceber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtReceber.Location = new System.Drawing.Point(616, 92);
            this.txtReceber.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceber.Multiline = true;
            this.txtReceber.Name = "txtReceber";
            this.txtReceber.ReadOnly = true;
            this.txtReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceber.Size = new System.Drawing.Size(461, 256);
            this.txtReceber.TabIndex = 5;
            this.txtReceber.Click += new System.EventHandler(this.txtReceber_TextChanged);
            this.txtReceber.TextChanged += new System.EventHandler(this.txtReceber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 806);
            this.Controls.Add(this.txtReceber);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Comunicação Serial COM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtEnviar;
        public System.Windows.Forms.TextBox txtReceber;
    }
}

