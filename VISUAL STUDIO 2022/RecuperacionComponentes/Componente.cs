using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RecuperacionComponentes
{
    public partial class Componente : UserControl
    {
        private int _maxElementos;

        // Evento del componente
        [Browsable(true)]
        [Category("!Creados")]
        [Description("Se ha añadido un elemento")]
        public event EventHandler elementoAnyadido;


        // Propiedades del componente
        [Category("!Creados")]
        [Description("Máximo elementos del listado")]
        public int maxElementosListado
        {
            get
            {
                return _maxElementos;
            }
            set
            {
                if (value < 0)
                {
                    _maxElementos = 0;
                }
                else
                {
                    _maxElementos = value;
                }
            }
        }

        [Category("!Creados")]
        [Description("Máximo caracteres de la caja de texto")]
        public int maxCaracteresTextBox
        {
            get
            {
                return textBox1.MaxLength;
            }
            set
            {
                if (value < 0)
                {
                    textBox1.MaxLength = 0;
                }
                else
                {
                    textBox1.MaxLength = value;
                }
            }
        }

        [Category("!Creados")]
        [Description("Color de fondo del slider")]
        public Color backgroundSlider
        {
            get
            {
                return trackBar1.BackColor;
            }
            set
            {
                trackBar1.BackColor = value;
            }
        }

        [Browsable(false)]
        [Category("!Creados")]
        [Description("Lista de elementos")]
        public List<String> listaElementos
        {
            get
            {
                return listBox1.Items.Cast<String>().ToList();
            }
        }

        public Componente()
        {
            InitializeComponent();
            setTrackBar();
        }

        // Función para deshabilitar la caja de texto si se llega al máximo de elementos
        private void maximumItems()
        {
            if (listBox1.Items.Count == _maxElementos)
            {
                textBox1.Text = "";
                textBox1.Enabled = false;
                textBox1.BackColor = Color.Red;
            } else
            {
                textBox1.Enabled = true;
                textBox1.BackColor = Color.White;
            }
        }

        // Función para actualizar el slider
        private void setTrackBar()
        {
            if (listBox1.Items.Count > 0)
            {
                trackBar1.Maximum = listBox1.Items.Count;
                trackBar1.Minimum = 1;
            }
            else
            {
                trackBar1.Maximum = listBox1.Items.Count;
                trackBar1.Minimum = 0;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            maximumItems();

            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                setTrackBar();

                if (this.elementoAnyadido != null)
                {
                    elementoAnyadido(this, new EventArgs());
                }
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                setTrackBar();
            }

            maximumItems();
        }
    }
}