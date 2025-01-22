namespace Partido
{
    partial class VideoMarcador
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoMarcador));
            this.nombre_local = new System.Windows.Forms.Label();
            this.nombre_visitante = new System.Windows.Forms.Label();
            this.parte = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tiempo_partido = new System.Windows.Forms.Label();
            this.escudo_visitante = new System.Windows.Forms.PictureBox();
            this.escudo_local = new System.Windows.Forms.PictureBox();
            this.img_visitante_gol = new System.Windows.Forms.PictureBox();
            this.img_gol_local = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.escudo_visitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escudo_local)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_visitante_gol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_gol_local)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_local
            // 
            this.nombre_local.AutoSize = true;
            this.nombre_local.Location = new System.Drawing.Point(66, 49);
            this.nombre_local.Name = "nombre_local";
            this.nombre_local.Size = new System.Drawing.Size(40, 16);
            this.nombre_local.TabIndex = 2;
            this.nombre_local.Text = "Local";
            // 
            // nombre_visitante
            // 
            this.nombre_visitante.AutoSize = true;
            this.nombre_visitante.Location = new System.Drawing.Point(289, 49);
            this.nombre_visitante.Name = "nombre_visitante";
            this.nombre_visitante.Size = new System.Drawing.Size(58, 16);
            this.nombre_visitante.TabIndex = 3;
            this.nombre_visitante.Text = "Visitante";
            // 
            // parte
            // 
            this.parte.AutoSize = true;
            this.parte.Location = new System.Drawing.Point(176, 15);
            this.parte.Name = "parte";
            this.parte.Size = new System.Drawing.Size(54, 16);
            this.parte.TabIndex = 4;
            this.parte.Text = "1º Parte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(193, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 10);
            this.panel1.TabIndex = 5;
            // 
            // tiempo_partido
            // 
            this.tiempo_partido.AutoSize = true;
            this.tiempo_partido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo_partido.Location = new System.Drawing.Point(179, 34);
            this.tiempo_partido.Name = "tiempo_partido";
            this.tiempo_partido.Size = new System.Drawing.Size(50, 20);
            this.tiempo_partido.TabIndex = 8;
            this.tiempo_partido.Text = "00:00";
            // 
            // escudo_visitante
            // 
            this.escudo_visitante.Location = new System.Drawing.Point(324, 70);
            this.escudo_visitante.Name = "escudo_visitante";
            this.escudo_visitante.Size = new System.Drawing.Size(86, 98);
            this.escudo_visitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.escudo_visitante.TabIndex = 7;
            this.escudo_visitante.TabStop = false;
            // 
            // escudo_local
            // 
            this.escudo_local.Location = new System.Drawing.Point(3, 70);
            this.escudo_local.Name = "escudo_local";
            this.escudo_local.Size = new System.Drawing.Size(86, 98);
            this.escudo_local.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.escudo_local.TabIndex = 6;
            this.escudo_local.TabStop = false;
            // 
            // img_visitante_gol
            // 
            this.img_visitante_gol.Image = ((System.Drawing.Image)(resources.GetObject("img_visitante_gol.Image")));
            this.img_visitante_gol.Location = new System.Drawing.Point(234, 70);
            this.img_visitante_gol.Name = "img_visitante_gol";
            this.img_visitante_gol.Size = new System.Drawing.Size(83, 98);
            this.img_visitante_gol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_visitante_gol.TabIndex = 1;
            this.img_visitante_gol.TabStop = false;
            // 
            // img_gol_local
            // 
            this.img_gol_local.Image = global::Partido.Properties.Resources.cero;
            this.img_gol_local.Location = new System.Drawing.Point(95, 70);
            this.img_gol_local.Name = "img_gol_local";
            this.img_gol_local.Size = new System.Drawing.Size(83, 98);
            this.img_gol_local.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_gol_local.TabIndex = 0;
            this.img_gol_local.TabStop = false;
            // 
            // VideoMarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tiempo_partido);
            this.Controls.Add(this.escudo_visitante);
            this.Controls.Add(this.escudo_local);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parte);
            this.Controls.Add(this.nombre_visitante);
            this.Controls.Add(this.nombre_local);
            this.Controls.Add(this.img_visitante_gol);
            this.Controls.Add(this.img_gol_local);
            this.MinimumSize = new System.Drawing.Size(410, 187);
            this.Name = "VideoMarcador";
            this.Size = new System.Drawing.Size(410, 187);
            ((System.ComponentModel.ISupportInitialize)(this.escudo_visitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escudo_local)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_visitante_gol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_gol_local)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_gol_local;
        private System.Windows.Forms.PictureBox img_visitante_gol;
        private System.Windows.Forms.Label nombre_local;
        private System.Windows.Forms.Label nombre_visitante;
        private System.Windows.Forms.Label parte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox escudo_local;
        private System.Windows.Forms.PictureBox escudo_visitante;
        private System.Windows.Forms.Label tiempo_partido;
    }
}
