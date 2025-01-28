using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inicioGoles();
        }

        private void inicioGoles()
        {
            trackBar_goles_local.Value = videoMarcador1.golesLocal;
            trackBar_goles_visitante.Value = videoMarcador1.golesVisitante;
        }

        private void trackBar_goles_local_ValueChanged(object sender, EventArgs e)
        {
            videoMarcador1.golesLocal = trackBar_goles_local.Value;
        }

        private void trackBar_goles_visitante_ValueChanged(object sender, EventArgs e)
        {
            videoMarcador1.golesVisitante = trackBar_goles_visitante.Value;
        }

        private void parte_partido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(parte_partido.SelectedIndex == 0)
            {
                videoMarcador1.parte_partido = "1º Parte";
                videoMarcador1.segundos = 0;
                videoMarcador1.minutos = 0;
            } else
            {
                videoMarcador1.parte_partido = "2º Parte";
                videoMarcador1.segundos = 0;
                videoMarcador1.minutos = 45;
            }
        }

        private void button_aumento_segundos_Click(object sender, EventArgs e)
        {
            if((parte_partido.SelectedIndex == 0 && videoMarcador1.minutos < 45) ||
               (parte_partido.SelectedIndex == 1 && videoMarcador1.minutos < 90))
            {
                videoMarcador1.sumaSegundo();

                if(videoMarcador1.segundos == 59)
                {
                    videoMarcador1.segundos = 0;
                    videoMarcador1.minutos++;
                }
            }
        }

        private void button_resta_segundos_Click(object sender, EventArgs e)
        {
            if ((parte_partido.SelectedIndex == 0 && videoMarcador1.minutos > 0) ||
               (parte_partido.SelectedIndex == 1 && videoMarcador1.minutos > 45))
            {
                videoMarcador1.restaSegundo();

                if(videoMarcador1.segundos == 0)
                {
                    videoMarcador1.segundos = 59;

                    if (videoMarcador1.minutos != 0)
                    {
                        videoMarcador1.minutos--;
                    }
                }
            }
        }

        private void button_aumento_minutos_Click(object sender, EventArgs e)
        {
            if((parte_partido.SelectedIndex == 0 && videoMarcador1.minutos < 45) || 
               (parte_partido.SelectedIndex == 1 && videoMarcador1.minutos < 90))
            {
                videoMarcador1.sumaMinuto();
            }
        }

        private void button_resta_minutos_Click(object sender, EventArgs e)
        {
            if ((parte_partido.SelectedIndex == 0 && videoMarcador1.minutos > 0) ||
               (parte_partido.SelectedIndex == 1 && videoMarcador1.minutos > 45))
            {
                videoMarcador1.restaMinuto();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            videoMarcador1.sumaSegundo();


        }
    }
}