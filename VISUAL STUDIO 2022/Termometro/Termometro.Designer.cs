namespace Termometro
{
    partial class Termometro
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
            this.valueTemperature = new System.Windows.Forms.TrackBar();
            this.imageTemperature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.valueTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // valueTemperature
            // 
            this.valueTemperature.LargeChange = 1;
            this.valueTemperature.Location = new System.Drawing.Point(3, 3);
            this.valueTemperature.Maximum = 5;
            this.valueTemperature.Minimum = 1;
            this.valueTemperature.Name = "valueTemperature";
            this.valueTemperature.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.valueTemperature.Size = new System.Drawing.Size(56, 130);
            this.valueTemperature.TabIndex = 0;
            this.valueTemperature.Value = 1;
            this.valueTemperature.ValueChanged += new System.EventHandler(this.valueTemperature_ValueChanged);
            // 
            // imageTemperature
            // 
            this.imageTemperature.Image = global::Termometro.Properties.Resources.frozen;
            this.imageTemperature.Location = new System.Drawing.Point(65, 3);
            this.imageTemperature.Name = "imageTemperature";
            this.imageTemperature.Size = new System.Drawing.Size(122, 130);
            this.imageTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageTemperature.TabIndex = 1;
            this.imageTemperature.TabStop = false;
            // 
            // Termometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageTemperature);
            this.Controls.Add(this.valueTemperature);
            this.MaximumSize = new System.Drawing.Size(194, 138);
            this.MinimumSize = new System.Drawing.Size(194, 138);
            this.Name = "Termometro";
            this.Size = new System.Drawing.Size(194, 138);
            ((System.ComponentModel.ISupportInitialize)(this.valueTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar valueTemperature;
        private System.Windows.Forms.PictureBox imageTemperature;
    }
}
