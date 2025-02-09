using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaInformes_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectDatabase(reportViewer1, "empleados", "SELECT * FROM departamentos");
            this.reportViewer1.RefreshReport();
        }

        private void connectDatabase(ReportViewer reporte, string database, string sql)
        {
            string connection = "Server=localhost; Port=5432; User Id=postgres; Password=iesbelen; Database= " + database;

            using(NpgsqlConnection conn = new NpgsqlConnection(connection))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ReportDataSource reportDataSource = new ReportDataSource("datosEmpleados", dt);
                reporte.LocalReport.DataSources.Clear();
                reporte.LocalReport.DataSources.Add(reportDataSource);
            }
        }
    }
}
