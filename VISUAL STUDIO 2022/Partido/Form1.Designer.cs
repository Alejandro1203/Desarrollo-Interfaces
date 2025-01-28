namespace Partido
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar_goles_local = new System.Windows.Forms.TrackBar();
            this.trackBar_goles_visitante = new System.Windows.Forms.TrackBar();
            this.parte_partido = new System.Windows.Forms.ComboBox();
            this.label_elegirParte = new System.Windows.Forms.Label();
            this.button_aumento_segundos = new System.Windows.Forms.Button();
            this.button_resta_segundos = new System.Windows.Forms.Button();
            this.button_aumento_minutos = new System.Windows.Forms.Button();
            this.button_resta_minutos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.videoMarcador1 = new Partido.VideoMarcador();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_goles_local)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_goles_visitante)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_goles_local
            // 
            this.trackBar_goles_local.LargeChange = 1;
            this.trackBar_goles_local.Location = new System.Drawing.Point(141, 12);
            this.trackBar_goles_local.Maximum = 9;
            this.trackBar_goles_local.Name = "trackBar_goles_local";
            this.trackBar_goles_local.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_goles_local.Size = new System.Drawing.Size(56, 187);
            this.trackBar_goles_local.TabIndex = 1;
            this.trackBar_goles_local.ValueChanged += new System.EventHandler(this.trackBar_goles_local_ValueChanged);
            // 
            // trackBar_goles_visitante
            // 
            this.trackBar_goles_visitante.LargeChange = 1;
            this.trackBar_goles_visitante.Location = new System.Drawing.Point(617, 12);
            this.trackBar_goles_visitante.Maximum = 9;
            this.trackBar_goles_visitante.Name = "trackBar_goles_visitante";
            this.trackBar_goles_visitante.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_goles_visitante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_goles_visitante.Size = new System.Drawing.Size(56, 187);
            this.trackBar_goles_visitante.TabIndex = 2;
            this.trackBar_goles_visitante.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_goles_visitante.ValueChanged += new System.EventHandler(this.trackBar_goles_visitante_ValueChanged);
            // 
            // parte_partido
            // 
            this.parte_partido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parte_partido.FormattingEnabled = true;
            this.parte_partido.Items.AddRange(new object[] {
            "Primera parte",
            "Segunda Parte"});
            this.parte_partido.Location = new System.Drawing.Point(343, 226);
            this.parte_partido.Name = "parte_partido";
            this.parte_partido.Size = new System.Drawing.Size(129, 24);
            this.parte_partido.TabIndex = 3;
            this.parte_partido.SelectedIndexChanged += new System.EventHandler(this.parte_partido_SelectedIndexChanged);
            // 
            // label_elegirParte
            // 
            this.label_elegirParte.AutoSize = true;
            this.label_elegirParte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_elegirParte.Location = new System.Drawing.Point(359, 205);
            this.label_elegirParte.Name = "label_elegirParte";
            this.label_elegirParte.Size = new System.Drawing.Size(86, 18);
            this.label_elegirParte.TabIndex = 4;
            this.label_elegirParte.Text = "Elegir parte ";
            // 
            // button_aumento_segundos
            // 
            this.button_aumento_segundos.Location = new System.Drawing.Point(311, 327);
            this.button_aumento_segundos.Name = "button_aumento_segundos";
            this.button_aumento_segundos.Size = new System.Drawing.Size(89, 32);
            this.button_aumento_segundos.TabIndex = 5;
            this.button_aumento_segundos.Text = "+ Segundo";
            this.button_aumento_segundos.UseVisualStyleBackColor = true;
            this.button_aumento_segundos.Click += new System.EventHandler(this.button_aumento_segundos_Click);
            // 
            // button_resta_segundos
            // 
            this.button_resta_segundos.Location = new System.Drawing.Point(418, 327);
            this.button_resta_segundos.Name = "button_resta_segundos";
            this.button_resta_segundos.Size = new System.Drawing.Size(89, 32);
            this.button_resta_segundos.TabIndex = 6;
            this.button_resta_segundos.Text = "- Segundo";
            this.button_resta_segundos.UseVisualStyleBackColor = true;
            this.button_resta_segundos.Click += new System.EventHandler(this.button_resta_segundos_Click);
            // 
            // button_aumento_minutos
            // 
            this.button_aumento_minutos.Location = new System.Drawing.Point(311, 376);
            this.button_aumento_minutos.Name = "button_aumento_minutos";
            this.button_aumento_minutos.Size = new System.Drawing.Size(89, 32);
            this.button_aumento_minutos.TabIndex = 7;
            this.button_aumento_minutos.Text = "+ Minuto";
            this.button_aumento_minutos.UseVisualStyleBackColor = true;
            this.button_aumento_minutos.Click += new System.EventHandler(this.button_aumento_minutos_Click);
            // 
            // button_resta_minutos
            // 
            this.button_resta_minutos.Location = new System.Drawing.Point(418, 376);
            this.button_resta_minutos.Name = "button_resta_minutos";
            this.button_resta_minutos.Size = new System.Drawing.Size(89, 32);
            this.button_resta_minutos.TabIndex = 8;
            this.button_resta_minutos.Text = "- Minuto";
            this.button_resta_minutos.UseVisualStyleBackColor = true;
            this.button_resta_minutos.Click += new System.EventHandler(this.button_resta_minutos_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // videoMarcador1
            // 
            this.videoMarcador1.EscudoLocal = global::Partido.Properties.Resources.barca;
            this.videoMarcador1.EscudoVisitante = global::Partido.Properties.Resources.Inter_miami_cf_logo;
            this.videoMarcador1.golesLocal = 4;
            this.videoMarcador1.golesVisitante = 4;
            this.videoMarcador1.Location = new System.Drawing.Point(201, 12);
            this.videoMarcador1.MinimumSize = new System.Drawing.Size(410, 187);
            this.videoMarcador1.minutos = 0;
            this.videoMarcador1.Name = "videoMarcador1";
            this.videoMarcador1.NombreLocal = "F.C. Barcelona";
            this.videoMarcador1.NombreVisitante = "Inter Miami";
            this.videoMarcador1.parte_partido = "1º Parte";
            this.videoMarcador1.segundos = 0;
            this.videoMarcador1.Size = new System.Drawing.Size(410, 187);
            this.videoMarcador1.TabIndex = 0;
            this.videoMarcador1.TiempoTranscurrido = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Partido.Properties.Resources.campo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(833, 549);
            this.Controls.Add(this.button_resta_minutos);
            this.Controls.Add(this.button_aumento_minutos);
            this.Controls.Add(this.button_resta_segundos);
            this.Controls.Add(this.button_aumento_segundos);
            this.Controls.Add(this.label_elegirParte);
            this.Controls.Add(this.parte_partido);
            this.Controls.Add(this.trackBar_goles_visitante);
            this.Controls.Add(this.trackBar_goles_local);
            this.Controls.Add(this.videoMarcador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_goles_local)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_goles_visitante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoMarcador videoMarcador1;
        private System.Windows.Forms.TrackBar trackBar_goles_local;
        private System.Windows.Forms.TrackBar trackBar_goles_visitante;
        private System.Windows.Forms.ComboBox parte_partido;
        private System.Windows.Forms.Label label_elegirParte;
        private System.Windows.Forms.Button button_aumento_segundos;
        private System.Windows.Forms.Button button_resta_segundos;
        private System.Windows.Forms.Button button_aumento_minutos;
        private System.Windows.Forms.Button button_resta_minutos;
        private System.Windows.Forms.Timer timer1;
    }
}

