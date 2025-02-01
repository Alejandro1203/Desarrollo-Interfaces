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

namespace PruebaInformes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            rellenarDataSet(reportViewer1);
            this.reportViewer1.RefreshReport();
        }

        private void rellenarDataSet(ReportViewer reporte)
        {
            this.reportViewer1.RefreshReport();

            List<Notas> listaNotas = new List<Notas>()
            {
                new Notas { Nombre = "Alejandro", Nota = 10, Observacion = "Es un grande" },
                new Notas { Nombre = "Alejandro", Nota = 10, Observacion = "Es un grande" },
                new Notas { Nombre = "Alejandro", Nota = 10, Observacion = "Es un grande" },
                new Notas { Nombre = "Alejandro", Nota = 10, Observacion = "Es un grande" }
            };

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", listaNotas);
            reporte.LocalReport.DataSources.Clear();
            reporte.LocalReport.DataSources.Add(reportDataSource);
        }
    }
}