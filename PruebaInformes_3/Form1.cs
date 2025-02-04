using Microsoft.Reporting.WinForms;
using System;
using RestSharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PruebaInformes_3
{
    public partial class Form1 : Form
    {
        private int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            importApiData(reportViewer1);
            report1();  

            this.reportViewer1.RefreshReport();
        }

        private void importApiData(ReportViewer reporte)
        {
            RestClient client = new RestClient("https://fakestoreapi.com/");
            RestRequest request = new RestRequest("products");
            
            RestResponse response = client.Execute(request);
            List<Product> listProducts = JsonConvert.DeserializeObject<List<Product>>(response.Content);
            List<Rating> listaRatings = new List<Rating>();

            foreach(Product product in listProducts)
            {
                listaRatings.Add(product.rating);
                num++;
            }

            reporte.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", listProducts);
            reporte.LocalReport.DataSources.Add(reportDataSource1);

            ReportDataSource reportDataSource2 = new ReportDataSource("DataSet2", listaRatings);
            reporte.LocalReport.DataSources.Add(reportDataSource2);
        }

        private void report1()
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", num.ToString()));
        }
    }
}
