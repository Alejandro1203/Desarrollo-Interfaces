using RehechoVentaCoches.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehechoVentaCoches
{
    public partial class Form1 : Form
    {
        List<Coche> listaCoches = new List<Coche>()
        {
            new Coche("911 Carrera", 56000),
            new Coche("Panamera", 82500),
            new Coche("Cayenne", 122000)
        };

        List<Extra> listaExtras = new List<Extra>()
        {
            new Extra("Audio Bose",700),
            new Extra("Bizona",650),
            new Extra("Camara trasera",350) ,
            new Extra("Sensores",450),
            new Extra("Cuero",1200),
            new Extra("Control. velocidad",320),
            new Extra("Cambio carril",400),
            new Extra("GPS", 600),
            new Extra("Llantas 18\"", 1000),
            new Extra("Asist. aparcamiento", 500),
            new Extra("Cambio Automatico", 1100),
            new Extra("Android", 250),
            new Extra("CR7 Asistente", 300),
            new Extra("Asientos calefactores", 400)
    };

        private void cargarExtrasDisponibles(List<Extra> lista, int cantidad)
        {
            listBox_ExtrasDisponibles.Items.Clear();

            for (int indice = 0; indice < cantidad; indice++)
            {
                listBox_ExtrasDisponibles.Items.Add(lista[indice].Nombre);
            }
        }

        private void actualizarPrecioModelo()
        {
            textBox_PrecioCoche.Text = listaCoches[comboBox_Modelo.SelectedIndex].Precio.ToString();
            actualizarBaseImponible();
        }

        private void actualizarPrecioExtras()
        {
            int total = 0;
            string item;

            foreach(DataGridViewRow row in dataGridView_ExtrasSeleccionados.Rows)
            {
                item = row.Cells[0].Value.ToString();

                total += listaExtras.First(i => i.Nombre.Equals(item)).Precio;
            }

            textBox_PrecioExtras.Text = total.ToString();
            actualizarBaseImponible();
        }

        private void actualizarBaseImponible()
        {
            textBox_BaseImponible.Text = Convert.ToString(Convert.ToInt64(textBox_PrecioCoche.Text) + Convert.ToInt64(textBox_PrecioExtras.Text));
            actualizarIVA();
        }

        private void actualizarIVA()
        {
            textBox_IVA.Text = Convert.ToString((Convert.ToInt64(textBox_PrecioCoche.Text) + Convert.ToInt64(textBox_PrecioExtras.Text)) * 0.21);
            actualizarTotal();
        }

        private void actualizarIntereses()
        {
            actualizarTotal();
        }

        private void actualizarTotal()
        {
            textBox_PrecioTotal.Text = Convert.ToString(Convert.ToInt64(textBox_BaseImponible.Text) + Convert.ToInt64(textBox_IVA.Text) + Convert.ToInt64(textBox_InteresesPago.Text));
        }

        public Form1()
        {
            InitializeComponent();
            dateTimePicker_Entrega.MinDate = DateTime.Now;
        }

        private void comboBox_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_ExtrasSeleccionados.Rows.Clear();

            switch(comboBox_Modelo.SelectedIndex)
            {
                case 0:
                    imagenCoche.Image = Resources._911_carrera_11zonpng;
                    cargarExtrasDisponibles(listaExtras, 4);
                    break;

                case 1:
                    imagenCoche.Image = Resources.panamera_11zonpng;
                    cargarExtrasDisponibles(listaExtras, 9);
                    break;

                case 2:
                    imagenCoche.Image = Resources.cayenne_11zonpng;
                    cargarExtrasDisponibles(listaExtras, 14);
                    break;
            }

            actualizarPrecioModelo();
            actualizarPrecioExtras();
        }

        private void button_Anyadir_Click(object sender, EventArgs e)
        {
            if(listBox_ExtrasDisponibles.SelectedIndices.Count > 0)
            {
                List<string> values = new List<string>();

                foreach(int indice in listBox_ExtrasDisponibles.SelectedIndices)
                {
                    string nombreExtra = listBox_ExtrasDisponibles.Items[indice].ToString();
                    int precio = listaExtras.First(i => i.Nombre.Equals(nombreExtra)).Precio;

                    dataGridView_ExtrasSeleccionados.Rows.Add(nombreExtra, precio);

                    values.Add(nombreExtra);
                }

                foreach (string v in values)
                {
                    listBox_ExtrasDisponibles.Items.Remove(v);
                }

                actualizarPrecioExtras();
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            if(dataGridView_ExtrasSeleccionados.SelectedRows.Count > 0)
            {
                listBox_ExtrasDisponibles.Items.Add(dataGridView_ExtrasSeleccionados.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView_ExtrasSeleccionados.Rows.RemoveAt(dataGridView_ExtrasSeleccionados.SelectedRows[0].Index);

                actualizarPrecioExtras();
            }
        }

        private void checkBox_Financiacion_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Financiacion.Checked)
            {
                panel_Financiacion.Enabled = true;
            } else
            {
                panel_Financiacion.Enabled = false;
            }
        }
    }
}
