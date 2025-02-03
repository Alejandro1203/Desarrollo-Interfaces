using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaInforme_4
{
    public partial class Form2 : Form
    {
        public bool CheckNuevayol { get; set; }
        public bool CheckLosangeles { get; set; }
        public bool CheckChicago { get; set; }
        public bool CiudadGrande { get; set; }
        public string CiudadConcreta { get; set; }
        public List<Ciudad> ListaCiudades { get; set; }

        public int _nFilas = 0;

        public Form2()  
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();
            this.reportViewer1.RefreshReport();
        }

        private List<Ciudad> FciudadConcreta(List<Ciudad> listaCiudades)
        {
            List<Ciudad> ciudadesGrandes = new List<Ciudad>();
            ciudadesGrandes = listaCiudades.FindAll(a => a.Name.Equals(CiudadConcreta)).ToList();
            return ciudadesGrandes;
        }

        private List<Ciudad> FciudadesGrandes(List<Ciudad> listaCiudades)
        {
            List<Ciudad> ciudadesGrandes = new List<Ciudad>();

            ciudadesGrandes = listaCiudades.FindAll(ciudad => ciudad.Population > 1000000).ToList();

            return ciudadesGrandes;
        }

        private List<Ciudad> FzonaHoraria(List<Ciudad> listaCiudades)
        {
            List<Ciudad> ciudadesZonaHoraria = new List<Ciudad>();

            if (CheckNuevayol)
            {
                ciudadesZonaHoraria = listaCiudades.FindAll(ciudad => ciudad.Timezone.Equals("America/New_York")).ToList();
            }
            else if (CheckLosangeles)
            {
                ciudadesZonaHoraria = listaCiudades.FindAll(ciudad => ciudad.Timezone.Equals("America/Los_Angeles")).ToList();
            }
            else if (CheckChicago)
            {
                ciudadesZonaHoraria = listaCiudades.FindAll(ciudad => ciudad.Timezone.Equals("America/Chicago")).ToList();
            }

            return ciudadesZonaHoraria;
        }

        private void loadData()
        {
            List<Ciudad> ciudades = new List<Ciudad>();

            if ("".Equals(CiudadConcreta))
            {
                ciudades = FzonaHoraria(ListaCiudades);

                if (CiudadGrande)
                {
                    ciudades = FciudadesGrandes(ListaCiudades);
                }

            } else
            {
                ciudades = (FciudadConcreta(ListaCiudades));
            }

            _nFilas = ciudades.Count;
            ReportDataSource dt = new ReportDataSource("DataSet1", ciudades);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dt);
        }
    }
}
