using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RecuperacionComponentes
{
    public partial class Form1 : Form
    {

        private int _count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if(componente1.listaElementos.Count > 0)
            {
                textBox1.Text = componente1.listaElementos.OrderByDescending(i => i.Length).First();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(_count < 5)
            {
                pictureBox1.Visible = !pictureBox1.Visible;
                _count++;
            } else
            {
                timer1.Stop();
                pictureBox1.Visible = !pictureBox1.Visible;
                _count = 0;
            }
        }

        private void componente1_elementoAnyadido_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
    }
}
