namespace RehechoVentaCoches
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
            this.panelCoche = new System.Windows.Forms.Panel();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.comboBox_Modelo = new System.Windows.Forms.ComboBox();
            this.imagenCoche = new System.Windows.Forms.PictureBox();
            this.numericUpDown_Puertas = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroPuertas = new System.Windows.Forms.Label();
            this.dateTimePicker_Entrega = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_ExtrasDisponibles = new System.Windows.Forms.ListBox();
            this.dataGridView_ExtrasSeleccionados = new System.Windows.Forms.DataGridView();
            this.button_Anyadir = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nombreExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Meses = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Financiacion = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Cuota = new System.Windows.Forms.TextBox();
            this.textBox_Intereses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCoche.SuspendLayout();
            this.panelVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCoche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Puertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtrasSeleccionados)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Meses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCoche
            // 
            this.panelCoche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCoche.Controls.Add(this.panel4);
            this.panelCoche.Controls.Add(this.panel3);
            this.panelCoche.Controls.Add(this.panel2);
            this.panelCoche.Controls.Add(this.panel1);
            this.panelCoche.Controls.Add(this.imagenCoche);
            this.panelCoche.Location = new System.Drawing.Point(12, 12);
            this.panelCoche.Name = "panelCoche";
            this.panelCoche.Size = new System.Drawing.Size(693, 632);
            this.panelCoche.TabIndex = 0;
            // 
            // panelVenta
            // 
            this.panelVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVenta.Controls.Add(this.panel5);
            this.panelVenta.Location = new System.Drawing.Point(711, 12);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(411, 632);
            this.panelVenta.TabIndex = 1;
            // 
            // comboBox_Modelo
            // 
            this.comboBox_Modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Modelo.FormattingEnabled = true;
            this.comboBox_Modelo.Items.AddRange(new object[] {
            "911 Carrera",
            "Panamera",
            "Cayenne"});
            this.comboBox_Modelo.Location = new System.Drawing.Point(3, 26);
            this.comboBox_Modelo.Name = "comboBox_Modelo";
            this.comboBox_Modelo.Size = new System.Drawing.Size(152, 24);
            this.comboBox_Modelo.TabIndex = 1;
            this.comboBox_Modelo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Modelo_SelectedIndexChanged);
            // 
            // imagenCoche
            // 
            this.imagenCoche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagenCoche.Location = new System.Drawing.Point(3, 3);
            this.imagenCoche.Name = "imagenCoche";
            this.imagenCoche.Size = new System.Drawing.Size(362, 246);
            this.imagenCoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenCoche.TabIndex = 0;
            this.imagenCoche.TabStop = false;
            // 
            // numericUpDown_Puertas
            // 
            this.numericUpDown_Puertas.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_Puertas.Location = new System.Drawing.Point(83, 109);
            this.numericUpDown_Puertas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Puertas.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_Puertas.Name = "numericUpDown_Puertas";
            this.numericUpDown_Puertas.Size = new System.Drawing.Size(60, 22);
            this.numericUpDown_Puertas.TabIndex = 2;
            this.numericUpDown_Puertas.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelNumeroPuertas
            // 
            this.labelNumeroPuertas.AutoSize = true;
            this.labelNumeroPuertas.Location = new System.Drawing.Point(3, 111);
            this.labelNumeroPuertas.Name = "labelNumeroPuertas";
            this.labelNumeroPuertas.Size = new System.Drawing.Size(71, 16);
            this.labelNumeroPuertas.TabIndex = 3;
            this.labelNumeroPuertas.Text = "Nº Puertas";
            // 
            // dateTimePicker_Entrega
            // 
            this.dateTimePicker_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Entrega.Location = new System.Drawing.Point(6, 169);
            this.dateTimePicker_Entrega.Name = "dateTimePicker_Entrega";
            this.dateTimePicker_Entrega.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker_Entrega.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha de entrega";
            // 
            // listBox_ExtrasDisponibles
            // 
            this.listBox_ExtrasDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_ExtrasDisponibles.FormattingEnabled = true;
            this.listBox_ExtrasDisponibles.ItemHeight = 16;
            this.listBox_ExtrasDisponibles.Location = new System.Drawing.Point(3, 3);
            this.listBox_ExtrasDisponibles.Name = "listBox_ExtrasDisponibles";
            this.listBox_ExtrasDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_ExtrasDisponibles.Size = new System.Drawing.Size(211, 196);
            this.listBox_ExtrasDisponibles.TabIndex = 34;
            // 
            // dataGridView_ExtrasSeleccionados
            // 
            this.dataGridView_ExtrasSeleccionados.AllowUserToAddRows = false;
            this.dataGridView_ExtrasSeleccionados.AllowUserToDeleteRows = false;
            this.dataGridView_ExtrasSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ExtrasSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ExtrasSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreExtra,
            this.precioExtra});
            this.dataGridView_ExtrasSeleccionados.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_ExtrasSeleccionados.Name = "dataGridView_ExtrasSeleccionados";
            this.dataGridView_ExtrasSeleccionados.ReadOnly = true;
            this.dataGridView_ExtrasSeleccionados.RowHeadersWidth = 51;
            this.dataGridView_ExtrasSeleccionados.RowTemplate.Height = 24;
            this.dataGridView_ExtrasSeleccionados.Size = new System.Drawing.Size(293, 196);
            this.dataGridView_ExtrasSeleccionados.TabIndex = 35;
            // 
            // button_Anyadir
            // 
            this.button_Anyadir.Location = new System.Drawing.Point(3, 6);
            this.button_Anyadir.Name = "button_Anyadir";
            this.button_Anyadir.Size = new System.Drawing.Size(52, 38);
            this.button_Anyadir.TabIndex = 36;
            this.button_Anyadir.Text = ">>";
            this.button_Anyadir.UseVisualStyleBackColor = true;
            this.button_Anyadir.Click += new System.EventHandler(this.button_Anyadir_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(3, 62);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(52, 38);
            this.button_Eliminar.TabIndex = 37;
            this.button_Eliminar.Text = "<<";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker_Entrega);
            this.panel1.Controls.Add(this.labelNumeroPuertas);
            this.panel1.Controls.Add(this.numericUpDown_Puertas);
            this.panel1.Controls.Add(this.comboBox_Modelo);
            this.panel1.Location = new System.Drawing.Point(371, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 246);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.listBox_ExtrasDisponibles);
            this.panel2.Location = new System.Drawing.Point(3, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 205);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.button_Anyadir);
            this.panel3.Controls.Add(this.button_Eliminar);
            this.panel3.Location = new System.Drawing.Point(234, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 104);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dataGridView_ExtrasSeleccionados);
            this.panel4.Location = new System.Drawing.Point(303, 297);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 205);
            this.panel4.TabIndex = 36;
            // 
            // nombreExtra
            // 
            this.nombreExtra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreExtra.HeaderText = "Extra";
            this.nombreExtra.MinimumWidth = 6;
            this.nombreExtra.Name = "nombreExtra";
            this.nombreExtra.ReadOnly = true;
            // 
            // precioExtra
            // 
            this.precioExtra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.precioExtra.HeaderText = "Precio";
            this.precioExtra.MinimumWidth = 6;
            this.precioExtra.Name = "precioExtra";
            this.precioExtra.ReadOnly = true;
            this.precioExtra.Width = 75;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.textBox_Intereses);
            this.panel5.Controls.Add(this.textBox_Cuota);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.checkBox_Financiacion);
            this.panel5.Controls.Add(this.numericUpDown_Meses);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 190);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meses";
            // 
            // numericUpDown_Meses
            // 
            this.numericUpDown_Meses.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_Meses.Location = new System.Drawing.Point(59, 58);
            this.numericUpDown_Meses.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_Meses.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_Meses.Name = "numericUpDown_Meses";
            this.numericUpDown_Meses.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown_Meses.TabIndex = 2;
            this.numericUpDown_Meses.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // checkBox_Financiacion
            // 
            this.checkBox_Financiacion.AutoSize = true;
            this.checkBox_Financiacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Financiacion.Location = new System.Drawing.Point(3, 3);
            this.checkBox_Financiacion.Name = "checkBox_Financiacion";
            this.checkBox_Financiacion.Size = new System.Drawing.Size(189, 29);
            this.checkBox_Financiacion.TabIndex = 3;
            this.checkBox_Financiacion.Text = "FINANCIACIÓN";
            this.checkBox_Financiacion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cuota Inicial";
            // 
            // textBox_Cuota
            // 
            this.textBox_Cuota.Location = new System.Drawing.Point(92, 93);
            this.textBox_Cuota.MaxLength = 6;
            this.textBox_Cuota.Name = "textBox_Cuota";
            this.textBox_Cuota.Size = new System.Drawing.Size(100, 22);
            this.textBox_Cuota.TabIndex = 5;
            // 
            // textBox_Intereses
            // 
            this.textBox_Intereses.Location = new System.Drawing.Point(77, 132);
            this.textBox_Intereses.Name = "textBox_Intereses";
            this.textBox_Intereses.Size = new System.Drawing.Size(100, 22);
            this.textBox_Intereses.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intereses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 656);
            this.Controls.Add(this.panelVenta);
            this.Controls.Add(this.panelCoche);
            this.MinimumSize = new System.Drawing.Size(1152, 703);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCoche.ResumeLayout(false);
            this.panelVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenCoche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Puertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtrasSeleccionados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Meses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCoche;
        private System.Windows.Forms.PictureBox imagenCoche;
        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.ComboBox comboBox_Modelo;
        private System.Windows.Forms.NumericUpDown numericUpDown_Puertas;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Entrega;
        private System.Windows.Forms.Label labelNumeroPuertas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ExtrasSeleccionados;
        private System.Windows.Forms.ListBox listBox_ExtrasDisponibles;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Anyadir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioExtra;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBox_Financiacion;
        private System.Windows.Forms.NumericUpDown numericUpDown_Meses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Intereses;
        private System.Windows.Forms.TextBox textBox_Cuota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

