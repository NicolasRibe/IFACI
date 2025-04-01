namespace Sistema_de_sinalização
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbRuaVerde = new System.Windows.Forms.PictureBox();
            this.pbRuaAmarelo = new System.Windows.Forms.PictureBox();
            this.pbRuaVermelho = new System.Windows.Forms.PictureBox();
            this.pbAvenidaVermelho = new System.Windows.Forms.PictureBox();
            this.pbAvenidaAmarelo = new System.Windows.Forms.PictureBox();
            this.pbAvenidaVerde = new System.Windows.Forms.PictureBox();
            this.timerAvenidaVerde = new System.Windows.Forms.Timer(this.components);
            this.timerAvenidaVermelho = new System.Windows.Forms.Timer(this.components);
            this.timerAvenidaAmarelo = new System.Windows.Forms.Timer(this.components);
            this.timerRuaVerde = new System.Windows.Forms.Timer(this.components);
            this.timerRuaAmarelo = new System.Windows.Forms.Timer(this.components);
            this.timerRuaVermelho = new System.Windows.Forms.Timer(this.components);
            this.botaoStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerLabel = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuaVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuaAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuaVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvenidaVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvenidaAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvenidaVerde)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRuaVerde
            // 
            this.pbRuaVerde.BackColor = System.Drawing.Color.Transparent;
            this.pbRuaVerde.Image = ((System.Drawing.Image)(resources.GetObject("pbRuaVerde.Image")));
            this.pbRuaVerde.Location = new System.Drawing.Point(541, 204);
            this.pbRuaVerde.Name = "pbRuaVerde";
            this.pbRuaVerde.Size = new System.Drawing.Size(75, 190);
            this.pbRuaVerde.TabIndex = 0;
            this.pbRuaVerde.TabStop = false;
            // 
            // pbRuaAmarelo
            // 
            this.pbRuaAmarelo.BackColor = System.Drawing.Color.Transparent;
            this.pbRuaAmarelo.Image = ((System.Drawing.Image)(resources.GetObject("pbRuaAmarelo.Image")));
            this.pbRuaAmarelo.Location = new System.Drawing.Point(541, 204);
            this.pbRuaAmarelo.Name = "pbRuaAmarelo";
            this.pbRuaAmarelo.Size = new System.Drawing.Size(75, 190);
            this.pbRuaAmarelo.TabIndex = 1;
            this.pbRuaAmarelo.TabStop = false;
            // 
            // pbRuaVermelho
            // 
            this.pbRuaVermelho.BackColor = System.Drawing.Color.Transparent;
            this.pbRuaVermelho.Image = ((System.Drawing.Image)(resources.GetObject("pbRuaVermelho.Image")));
            this.pbRuaVermelho.Location = new System.Drawing.Point(541, 204);
            this.pbRuaVermelho.Name = "pbRuaVermelho";
            this.pbRuaVermelho.Size = new System.Drawing.Size(75, 190);
            this.pbRuaVermelho.TabIndex = 2;
            this.pbRuaVermelho.TabStop = false;
            // 
            // pbAvenidaVermelho
            // 
            this.pbAvenidaVermelho.BackColor = System.Drawing.Color.Transparent;
            this.pbAvenidaVermelho.Image = ((System.Drawing.Image)(resources.GetObject("pbAvenidaVermelho.Image")));
            this.pbAvenidaVermelho.Location = new System.Drawing.Point(170, 204);
            this.pbAvenidaVermelho.Name = "pbAvenidaVermelho";
            this.pbAvenidaVermelho.Size = new System.Drawing.Size(75, 190);
            this.pbAvenidaVermelho.TabIndex = 5;
            this.pbAvenidaVermelho.TabStop = false;
            // 
            // pbAvenidaAmarelo
            // 
            this.pbAvenidaAmarelo.BackColor = System.Drawing.Color.Transparent;
            this.pbAvenidaAmarelo.Image = ((System.Drawing.Image)(resources.GetObject("pbAvenidaAmarelo.Image")));
            this.pbAvenidaAmarelo.Location = new System.Drawing.Point(170, 204);
            this.pbAvenidaAmarelo.Name = "pbAvenidaAmarelo";
            this.pbAvenidaAmarelo.Size = new System.Drawing.Size(75, 190);
            this.pbAvenidaAmarelo.TabIndex = 4;
            this.pbAvenidaAmarelo.TabStop = false;
            // 
            // pbAvenidaVerde
            // 
            this.pbAvenidaVerde.BackColor = System.Drawing.Color.Transparent;
            this.pbAvenidaVerde.Image = ((System.Drawing.Image)(resources.GetObject("pbAvenidaVerde.Image")));
            this.pbAvenidaVerde.Location = new System.Drawing.Point(170, 204);
            this.pbAvenidaVerde.Name = "pbAvenidaVerde";
            this.pbAvenidaVerde.Size = new System.Drawing.Size(75, 190);
            this.pbAvenidaVerde.TabIndex = 3;
            this.pbAvenidaVerde.TabStop = false;
            // 
            // timerAvenidaVerde
            // 
            this.timerAvenidaVerde.Interval = 1000;
            this.timerAvenidaVerde.Tick += new System.EventHandler(this.timerAvenidaVerde_Tick);
            // 
            // timerAvenidaVermelho
            // 
            this.timerAvenidaVermelho.Interval = 1000;
            this.timerAvenidaVermelho.Tick += new System.EventHandler(this.timerAvenidaVermelho_Tick);
            // 
            // timerAvenidaAmarelo
            // 
            this.timerAvenidaAmarelo.Interval = 1000;
            this.timerAvenidaAmarelo.Tick += new System.EventHandler(this.timerAvenidaAmarelo_Tick);
            // 
            // timerRuaVerde
            // 
            this.timerRuaVerde.Interval = 1000;
            this.timerRuaVerde.Tick += new System.EventHandler(this.timerRuaVerde_Tick);
            // 
            // timerRuaAmarelo
            // 
            this.timerRuaAmarelo.Interval = 1000;
            this.timerRuaAmarelo.Tick += new System.EventHandler(this.timerRuaAmarelo_Tick);
            // 
            // timerRuaVermelho
            // 
            this.timerRuaVermelho.Interval = 1000;
            this.timerRuaVermelho.Tick += new System.EventHandler(this.timerRuaVermelho_Tick);
            // 
            // botaoStart
            // 
            this.botaoStart.BackColor = System.Drawing.Color.GreenYellow;
            this.botaoStart.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoStart.Location = new System.Drawing.Point(124, 502);
            this.botaoStart.Name = "botaoStart";
            this.botaoStart.Size = new System.Drawing.Size(158, 90);
            this.botaoStart.TabIndex = 6;
            this.botaoStart.Text = "START";
            this.botaoStart.UseVisualStyleBackColor = false;
            this.botaoStart.Click += new System.EventHandler(this.botaoStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 74);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerLabel
            // 
            this.timerLabel.Interval = 1000;
            this.timerLabel.Tick += new System.EventHandler(this.timerLabel_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(472, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 90);
            this.button1.TabIndex = 9;
            this.button1.Text = "Off";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(326, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Emergência";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(83, 20);
            this.toolStripSplitButton1.Text = "POLICIA";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(98, 20);
            this.toolStripSplitButton2.Text = "BOMBEIRO";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Sistema_de_sinalização.Properties.Resources.Avenida1;
            this.ClientSize = new System.Drawing.Size(765, 648);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoStart);
            this.Controls.Add(this.pbAvenidaVerde);
            this.Controls.Add(this.pbRuaVermelho);
            this.Controls.Add(this.pbRuaAmarelo);
            this.Controls.Add(this.pbRuaVerde);
            this.Controls.Add(this.pbAvenidaVermelho);
            this.Controls.Add(this.pbAvenidaAmarelo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbRuaVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuaAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuaVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvenidaVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvenidaAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvenidaVerde)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRuaVerde;
        private System.Windows.Forms.PictureBox pbRuaAmarelo;
        private System.Windows.Forms.PictureBox pbRuaVermelho;
        private System.Windows.Forms.PictureBox pbAvenidaVermelho;
        private System.Windows.Forms.PictureBox pbAvenidaAmarelo;
        private System.Windows.Forms.PictureBox pbAvenidaVerde;
        private System.Windows.Forms.Timer timerAvenidaVerde;
        private System.Windows.Forms.Timer timerAvenidaVermelho;
        private System.Windows.Forms.Timer timerAvenidaAmarelo;
        private System.Windows.Forms.Timer timerRuaVerde;
        private System.Windows.Forms.Timer timerRuaAmarelo;
        private System.Windows.Forms.Timer timerRuaVermelho;
        private System.Windows.Forms.Button botaoStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
    }
}

