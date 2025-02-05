namespace RecuperacionInforme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.txtbox_isbn = new System.Windows.Forms.TextBox();
            this.txtbox_maxpaginas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_nameauthor = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtbox_numauthors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros de búsqueda de libros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Por ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Por número máximo de páginas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Por nombre de autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Búsqueda por número de autores";
            // 
            // txtbox_title
            // 
            this.txtbox_title.Location = new System.Drawing.Point(76, 95);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(239, 22);
            this.txtbox_title.TabIndex = 6;
            // 
            // txtbox_isbn
            // 
            this.txtbox_isbn.Location = new System.Drawing.Point(80, 136);
            this.txtbox_isbn.Name = "txtbox_isbn";
            this.txtbox_isbn.Size = new System.Drawing.Size(235, 22);
            this.txtbox_isbn.TabIndex = 7;
            this.txtbox_isbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_isbn_KeyPress);
            // 
            // txtbox_maxpaginas
            // 
            this.txtbox_maxpaginas.Location = new System.Drawing.Point(215, 172);
            this.txtbox_maxpaginas.Name = "txtbox_maxpaginas";
            this.txtbox_maxpaginas.Size = new System.Drawing.Size(100, 22);
            this.txtbox_maxpaginas.TabIndex = 8;
            this.txtbox_maxpaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_maxpaginas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "BÚSQUEDAS";
            // 
            // txtbox_nameauthor
            // 
            this.txtbox_nameauthor.Location = new System.Drawing.Point(147, 207);
            this.txtbox_nameauthor.Name = "txtbox_nameauthor";
            this.txtbox_nameauthor.Size = new System.Drawing.Size(168, 22);
            this.txtbox_nameauthor.TabIndex = 10;
            this.txtbox_nameauthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_nameauthor_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(141, 308);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 27);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtbox_numauthors
            // 
            this.txtbox_numauthors.Location = new System.Drawing.Point(225, 248);
            this.txtbox_numauthors.Name = "txtbox_numauthors";
            this.txtbox_numauthors.Size = new System.Drawing.Size(90, 22);
            this.txtbox_numauthors.TabIndex = 12;
            this.txtbox_numauthors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_numauthors_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 395);
            this.Controls.Add(this.txtbox_numauthors);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtbox_nameauthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_maxpaginas);
            this.Controls.Add(this.txtbox_isbn);
            this.Controls.Add(this.txtbox_title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.TextBox txtbox_isbn;
        private System.Windows.Forms.TextBox txtbox_maxpaginas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_nameauthor;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtbox_numauthors;
    }
}

