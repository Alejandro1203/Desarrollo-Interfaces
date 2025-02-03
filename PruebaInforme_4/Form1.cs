using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaInforme_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.CheckNuevayol = radioButton1.Checked;
            f2.CheckLosangeles = radioButton2.Checked;
            f2.CheckChicago = radioButton3.Checked;
            f2.CiudadGrande = checkBox1.Checked;
            f2.CiudadConcreta = textBox1.Text;
            f2.ListaCiudades = listaCsv();
            f2.ShowDialog();
        }

        private List<Ciudad> listaCsv()
        {
            List<Ciudad> allProducts = new List<Ciudad>();
            List<string> productLines = File.ReadAllLines("..\\..\\Data\\Ciudades EEUU.csv").ToList();

            productLines.RemoveAt(0);

            foreach (string line in productLines)
            {
                string[] fields = line.Split(';');
                Ciudad product = new Ciudad();
                product.Name = fields[0];
                product.Latitude = fields[1];
                product.Longitude = fields[2];
                product.Population = Convert.ToInt32(fields[3]);
                product.Timezone = fields[4];
                allProducts.Add(product);
            }

            return allProducts;

        }
    }
}
