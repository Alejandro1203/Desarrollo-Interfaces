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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_ExtrasSeleccionados = new System.Windows.Forms.DataGridView();
            this.nombreExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Anyadir = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox_ExtrasDisponibles = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Entrega = new System.Windows.Forms.DateTimePicker();
            this.labelNumeroPuertas = new System.Windows.Forms.Label();
            this.numericUpDown_Puertas = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Modelo = new System.Windows.Forms.ComboBox();
            this.imagenCoche = new System.Windows.Forms.PictureBox();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_InteresesFinanciacion = new System.Windows.Forms.TextBox();
            this.textBox_Cuota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_Financiacion = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Meses = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_PrecioCoche = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_PrecioExtras = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_BaseImponible = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_IVA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_InteresesPago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_PrecioTotal = new System.Windows.Forms.TextBox();
            this.panel_Financiacion = new System.Windows.Forms.Panel();
            this.panelCoche.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtrasSeleccionados)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Puertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCoche)).BeginInit();
            this.panelVenta.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Meses)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel_Financiacion.SuspendLayout();
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
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha de entrega";
            // 
            // dateTimePicker_Entrega
            // 
            this.dateTimePicker_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Entrega.Location = new System.Drawing.Point(6, 169);
            this.dateTimePicker_Entrega.Name = "dateTimePicker_Entrega";
            this.dateTimePicker_Entrega.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker_Entrega.TabIndex = 32;
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
            // panelVenta
            // 
            this.panelVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVenta.Controls.Add(this.panel6);
            this.panelVenta.Controls.Add(this.panel5);
            this.panelVenta.Location = new System.Drawing.Point(711, 12);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(411, 632);
            this.panelVenta.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel_Financiacion);
            this.panel5.Controls.Add(this.checkBox_Financiacion);
            this.panel5.Location = new System.Drawing.Point(3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 190);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intereses";
            // 
            // textBox_InteresesFinanciacion
            // 
            this.textBox_InteresesFinanciacion.Location = new System.Drawing.Point(75, 72);
            this.textBox_InteresesFinanciacion.Name = "textBox_InteresesFinanciacion";
            this.textBox_InteresesFinanciacion.ReadOnly = true;
            this.textBox_InteresesFinanciacion.Size = new System.Drawing.Size(100, 22);
            this.textBox_InteresesFinanciacion.TabIndex = 6;
            // 
            // textBox_Cuota
            // 
            this.textBox_Cuota.Location = new System.Drawing.Point(90, 33);
            this.textBox_Cuota.MaxLength = 6;
            this.textBox_Cuota.Name = "textBox_Cuota";
            this.textBox_Cuota.Size = new System.Drawing.Size(100, 22);
            this.textBox_Cuota.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cuota Inicial";
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
            this.checkBox_Financiacion.CheckedChanged += new System.EventHandler(this.checkBox_Financiacion_CheckedChanged);
            // 
            // numericUpDown_Meses
            // 
            this.numericUpDown_Meses.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_Meses.Location = new System.Drawing.Point(56, 3);
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
            this.numericUpDown_Meses.ReadOnly = true;
            this.numericUpDown_Meses.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown_Meses.TabIndex = 2;
            this.numericUpDown_Meses.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "TOTAL A PAGAR";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox_PrecioTotal);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.textBox_InteresesPago);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.textBox_IVA);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.textBox_BaseImponible);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.textBox_PrecioExtras);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.textBox_PrecioCoche);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(6, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 429);
            this.panel6.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Coche";
            // 
            // textBox_PrecioCoche
            // 
            this.textBox_PrecioCoche.Location = new System.Drawing.Point(58, 46);
            this.textBox_PrecioCoche.Name = "textBox_PrecioCoche";
            this.textBox_PrecioCoche.ReadOnly = true;
            this.textBox_PrecioCoche.Size = new System.Drawing.Size(100, 22);
            this.textBox_PrecioCoche.TabIndex = 3;
            this.textBox_PrecioCoche.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Extras";
            // 
            // textBox_PrecioExtras
            // 
            this.textBox_PrecioExtras.Location = new System.Drawing.Point(58, 91);
            this.textBox_PrecioExtras.Name = "textBox_PrecioExtras";
            this.textBox_PrecioExtras.ReadOnly = true;
            this.textBox_PrecioExtras.Size = new System.Drawing.Size(100, 22);
            this.textBox_PrecioExtras.TabIndex = 5;
            this.textBox_PrecioExtras.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Base Imponible";
            // 
            // textBox_BaseImponible
            // 
            this.textBox_BaseImponible.Location = new System.Drawing.Point(113, 135);
            this.textBox_BaseImponible.Name = "textBox_BaseImponible";
            this.textBox_BaseImponible.ReadOnly = true;
            this.textBox_BaseImponible.Size = new System.Drawing.Size(100, 22);
            this.textBox_BaseImponible.TabIndex = 7;
            this.textBox_BaseImponible.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "IVA";
            // 
            // textBox_IVA
            // 
            this.textBox_IVA.Location = new System.Drawing.Point(40, 178);
            this.textBox_IVA.Name = "textBox_IVA";
            this.textBox_IVA.ReadOnly = true;
            this.textBox_IVA.Size = new System.Drawing.Size(100, 22);
            this.textBox_IVA.TabIndex = 9;
            this.textBox_IVA.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Intereses";
            // 
            // textBox_InteresesPago
            // 
            this.textBox_InteresesPago.Location = new System.Drawing.Point(74, 220);
            this.textBox_InteresesPago.Name = "textBox_InteresesPago";
            this.textBox_InteresesPago.ReadOnly = true;
            this.textBox_InteresesPago.Size = new System.Drawing.Size(100, 22);
            this.textBox_InteresesPago.TabIndex = 11;
            this.textBox_InteresesPago.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "TOTAL ";
            // 
            // textBox_PrecioTotal
            // 
            this.textBox_PrecioTotal.Location = new System.Drawing.Point(74, 299);
            this.textBox_PrecioTotal.Name = "textBox_PrecioTotal";
            this.textBox_PrecioTotal.ReadOnly = true;
            this.textBox_PrecioTotal.Size = new System.Drawing.Size(100, 22);
            this.textBox_PrecioTotal.TabIndex = 13;
            // 
            // panel_Financiacion
            // 
            this.panel_Financiacion.Controls.Add(this.label3);
            this.panel_Financiacion.Controls.Add(this.label4);
            this.panel_Financiacion.Controls.Add(this.numericUpDown_Meses);
            this.panel_Financiacion.Controls.Add(this.textBox_InteresesFinanciacion);
            this.panel_Financiacion.Controls.Add(this.label2);
            this.panel_Financiacion.Controls.Add(this.textBox_Cuota);
            this.panel_Financiacion.Enabled = false;
            this.panel_Financiacion.Location = new System.Drawing.Point(13, 49);
            this.panel_Financiacion.Name = "panel_Financiacion";
            this.panel_Financiacion.Size = new System.Drawing.Size(213, 107);
            this.panel_Financiacion.TabIndex = 8;
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
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtrasSeleccionados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Puertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenCoche)).EndInit();
            this.panelVenta.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Meses)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel_Financiacion.ResumeLayout(false);
            this.panel_Financiacion.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_InteresesFinanciacion;
        private System.Windows.Forms.TextBox textBox_Cuota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox_PrecioExtras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_PrecioCoche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_InteresesPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_IVA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_BaseImponible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_PrecioTotal;
        private System.Windows.Forms.Panel panel_Financiacion;
    }
}

