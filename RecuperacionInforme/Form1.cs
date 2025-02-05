using Newtonsoft.Json;
using RestSharp;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onlyLetters(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back));
        }

        private void onlyNumbers(KeyPressEventArgs e)
        {
            e.Handled = !((char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Titulo_libro = txtbox_title.Text;
            form2.ISBN_libro = txtbox_isbn.Text;

            if(txtbox_maxpaginas.Text == "")
            {
                form2.Max_paginas = 0;
            } else
            {
                form2.Max_paginas = Convert.ToInt32(txtbox_maxpaginas.Text);
            }
            
            form2.Name_author = txtbox_nameauthor.Text;

            if (txtbox_numauthors.Text == "")
            {
                form2.Num_author = 0;
            }
            else
            {
                form2.Num_author = Convert.ToInt32(txtbox_numauthors.Text);
            }
            
            form2.Lista_libros = importApiData();
            form2.ShowDialog();
            resetForm();
        }

        private List<Libro> importApiData()
        {
            RestClient client = new RestClient("https://softwium.com/api/");
            RestRequest request = new RestRequest("books");

            RestResponse response = client.Execute(request);
            List<Libro> listaLibros = JsonConvert.DeserializeObject<List<Libro>>(response.Content);

            return listaLibros;
        }

        private void resetForm()
        {
            txtbox_title.Text = "";
            txtbox_isbn.Text = "";
            txtbox_maxpaginas.Text = "";
            txtbox_nameauthor.Text = "";
            txtbox_numauthors.Text = "";
        }

        private void txtbox_isbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtbox_maxpaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        private void txtbox_nameauthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetters(e);
        }

        private void txtbox_numauthors_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }
    }
}
