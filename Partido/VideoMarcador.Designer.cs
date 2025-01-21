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
            this.img_gol_local = new System.Windows.Forms.PictureBox();
            this.img_visitante_gol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_gol_local)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_visitante_gol)).BeginInit();
            this.SuspendLayout();
            // 
            // img_gol_local
            // 
            this.img_gol_local.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_gol_local.Image = ((System.Drawing.Image)(resources.GetObject("img_gol_local.Image")));
            this.img_gol_local.Location = new System.Drawing.Point(150, 58);
            this.img_gol_local.Name = "img_gol_local";
            this.img_gol_local.Size = new System.Drawing.Size(236, 236);
            this.img_gol_local.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_gol_local.TabIndex = 0;
            this.img_gol_local.TabStop = false;
            // 
            // img_visitante_gol
            // 
            this.img_visitante_gol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_visitante_gol.Image = ((System.Drawing.Image)(resources.GetObject("img_visitante_gol.Image")));
            this.img_visitante_gol.Location = new System.Drawing.Point(446, 58);
            this.img_visitante_gol.Name = "img_visitante_gol";
            this.img_visitante_gol.Size = new System.Drawing.Size(236, 236);
            this.img_visitante_gol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_visitante_gol.TabIndex = 1;
            this.img_visitante_gol.TabStop = false;
            // 
            // VideoMarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img_visitante_gol);
            this.Controls.Add(this.img_gol_local);
            this.Name = "VideoMarcador";
            this.Size = new System.Drawing.Size(847, 400);
            ((System.ComponentModel.ISupportInitialize)(this.img_gol_local)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_visitante_gol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_gol_local;
        private System.Windows.Forms.PictureBox img_visitante_gol;
    }
}
