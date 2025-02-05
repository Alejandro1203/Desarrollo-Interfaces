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

namespace RecuperacionInforme
{
    public partial class Form2 : Form
    {

        public string Titulo_libro { get; set; }
        public string ISBN_libro { get; set; }
        public int Max_paginas { get; set; }
        public string Name_author { get; set; }
        public int Num_author { get; set; }
        public List<Libro> Lista_libros { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData(reportViewer1);
            this.reportViewer1.RefreshReport();
        }

        private void loadData(ReportViewer reporte)
        {
            List<Libro> listaLibros = new List<Libro>();
            List<Libro> listaLibrosFiltrados = new List<Libro>();

            if (Titulo_libro != "")
            {
                listaLibros.Add(filtroTituloLibro(Lista_libros));
            }

            if (ISBN_libro != "")
            {
                listaLibros.Add(filtroISBNLibro(Lista_libros));
            }

            if (Max_paginas != 0)
            {
                listaLibrosFiltrados = filtroMaxPaginas(Lista_libros);

                foreach(Libro libro in listaLibrosFiltrados)
                {
                    listaLibros.Add(libro);
                }

                ReportParameterMaxPaginas(Max_paginas);
            }

            if (Name_author != "")
            {
                listaLibrosFiltrados = filtroNameAuthor(Lista_libros);

                foreach (Libro libro in listaLibrosFiltrados)
                {
                    listaLibros.Add(libro);
                }

                ReportParameterAutor(Name_author);
            }

            if (Num_author != 0)
            {

                listaLibrosFiltrados = filtroNumAuthors(Lista_libros);

                foreach (Libro libro in listaLibrosFiltrados)
                {
                    listaLibros.Add(libro);
                }
            }

            ReportParameterFilas(listaLibros.Count);


            if(listaLibros.Count == 0)
            {
                reporte.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", Lista_libros);
                reporte.LocalReport.DataSources.Add(reportDataSource);
            } else
            {
                reporte.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", listaLibros);
                reporte.LocalReport.DataSources.Add(reportDataSource);
            }
            
        }

        private void ReportParameterFilas(int num)
        {
            if(num > 0)
            {
                reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", num.ToString()));
            } else
            {
                reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", "0"));
            }
        }

        private void ReportParameterAutor(string autor)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter2", "Estos son todos los libros de " + autor));
            
        }

        private void ReportParameterMaxPaginas(int paginas)
        {

            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter3", "Todos los libros mostrados tienen " + paginas + " páginas como máximo."));
            
        }

        private Libro filtroTituloLibro(List<Libro> listaLibro)
        {
            Libro libro = new Libro();

            libro = listaLibro.Find(l => l.title == Titulo_libro);

            return libro;
        }

        private Libro filtroISBNLibro(List<Libro> listaLibro)
        {
            Libro libro = new Libro();

            libro = listaLibro.Find(l => l.isbn == ISBN_libro);

            return libro;
        }

        private List<Libro> filtroMaxPaginas(List<Libro> listaLibro)
        {
            List<Libro> libros = new List<Libro>();

            libros = listaLibro.FindAll(l => l.pageCount <= Max_paginas);

            return libros;
        }

        private List<Libro> filtroNameAuthor(List<Libro> listaLibro)
        {
            List<Libro> libros = new List<Libro>();

            libros = listaLibro.FindAll(l => l.authors.Contains(Name_author));

            return libros;
        }

        private List<Libro> filtroNumAuthors(List<Libro> listaLibro)
        {
            List<Libro> libros = new List<Libro>();

            libros = listaLibro.FindAll(l => l.authors.Count == Num_author);

            return libros;
        }
    }
}
