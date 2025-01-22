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
    public partial class VideoMarcador : UserControl
    {
        private int _golesLocal;
        private int _golesVisitante;
        private int _segundos;
        private int _minutos;

        // Eventos

        //[Browsable(true)]
        //[Category("VideoMarcador")]
        //[Description("Suma un segundo al tiempo transcurrido")]
        //public event EventHandler SumaSegundo;

        //[Browsable(true)]
        //[Category("VideoMarcador")]
        //[Description("Resta un segundo al tiempo transcurrido")]
        //public event EventHandler RestaSegundo;


        // Propiedades

        [Category("VideoMarcador")]
        [Description("Nombre del local")]
        public string NombreLocal
        {
            get { return nombre_local.Text; }
            set { nombre_local.Text = value; }
        }

        [Category("VideoMarcador")]
        [Description("Nombre del visitante")]
        public string NombreVisitante
        {
            get { return nombre_visitante.Text; }
            set { nombre_visitante.Text = value; }
        }

        [Category("VideoMarcador")]
        [Description("Escudo del local")]
        public Image EscudoLocal
        {
            get { return escudo_local.Image; }
            set { escudo_local.Image = value; }
        }

        [Category("VideoMarcador")]
        [Description("Escudo del visitante")]
        public Image EscudoVisitante
        {
            get { return escudo_visitante.Image; }
            set { escudo_visitante.Image = value; }
        }

        [Category("VideoMarcador")]
        [Description("Tiempo transcurrido")]    
        public string TiempoTranscurrido
        {
            get { return tiempo_partido.Text; }
            set { tiempo_partido.Text = value; }
        }

        [Browsable(true)]
        [Category("VideoMarcador")]
        [Description("Goles del local")]
        public int golesLocal
        {
            get { return _golesVisitante; }
            set
            {
                if(value > 9)
                {
                    _golesVisitante = 9;
                } else if(value < 0)
                {
                    _golesVisitante = 0;
                } else
                {
                    _golesVisitante = value;
                }

                golLocal(_golesVisitante);
            }
        }

        [Browsable(true)]
        [Category("VideoMarcador")]
        [Description("Goles del visitante")]
        public int golesVisitante
        {
            get { return _golesLocal; }
            set
            {
                if (value > 9)
                {
                    _golesLocal = 9;
                }
                else if (value < 0)
                {
                    _golesLocal = 0;
                }
                else
                {
                    _golesLocal = value;
                }

                golVisitante(_golesLocal);
            }
        }

        [Browsable(true)]
        [Category("VideoMarcador")]
        [Description("Parte del partido")]
        public string parte_partido
        {
            get
            {
                return parte.Text;
            }

            set
            {
                parte.Text = value;
            }
        }

        [Browsable(false)]
        [Category("VideoMarcador")]
        [Description("Segundos")]
        public int segundos
        {
            get
            {
                return _segundos;
            }

            set 
            {
                _segundos = value;
                cargarTiempoTranscurrido();
            }
        }

        [Browsable(false)]
        [Category("VideoMarcador")]
        [Description("Minutos")]
        public int minutos
        {
            get
            {
                return _minutos;
            }

            set
            {
                _minutos = value;
                cargarTiempoTranscurrido();
            }
        }


        public VideoMarcador()
        {
            InitializeComponent();
        }

        private void golLocal(int golLocal)
        {
            switch (golLocal)
            {
                case 0:
                    img_gol_local.Image = Properties.Resources.cero;
                    break;

                case 1:
                    img_gol_local.Image = Properties.Resources.uno;
                    break;

                case 2:
                    img_gol_local.Image = Properties.Resources.dos;
                    break;

                case 3:
                    img_gol_local.Image = Properties.Resources.tres;
                    break;

                case 4:
                    img_gol_local.Image = Properties.Resources.cuatro;
                    break;

                case 5:
                    img_gol_local.Image = Properties.Resources.cinco;
                    break;

                case 6:
                    img_gol_local.Image = Properties.Resources.seis;
                    break;

                case 7:
                    img_gol_local.Image = Properties.Resources.siete;
                    break;

                case 8:
                    img_gol_local.Image = Properties.Resources.ocho;
                    break;

                case 9:
                    img_gol_local.Image = Properties.Resources.nueve;
                    break;
            }
        }

        private void golVisitante(int golVisitante)
        {
            switch (golVisitante)
            {
                case 0:
                    img_visitante_gol.Image = Properties.Resources.cero;
                    break;

                case 1:
                    img_visitante_gol.Image = Properties.Resources.uno;
                    break;

                case 2:
                    img_visitante_gol.Image = Properties.Resources.dos;
                    break;

                case 3:
                    img_visitante_gol.Image = Properties.Resources.tres;
                    break;

                case 4:
                    img_visitante_gol.Image = Properties.Resources.cuatro;
                    break;

                case 5:
                    img_visitante_gol.Image = Properties.Resources.cinco;
                    break;

                case 6:
                    img_visitante_gol.Image = Properties.Resources.seis;
                    break;

                case 7:
                    img_visitante_gol.Image = Properties.Resources.siete;
                    break;

                case 8:
                    img_visitante_gol.Image = Properties.Resources.ocho;
                    break;

                case 9:
                    img_visitante_gol.Image = Properties.Resources.nueve;
                    break;
            }
        }

        private void cargarTiempoTranscurrido()
        {
            if(_minutos < 10 && _segundos < 10)
            {
                tiempo_partido.Text = "0" + Convert.ToString(_minutos) + ":0" + Convert.ToString(_segundos);
            } else if(_minutos < 10 && _segundos > 9)
            {
                tiempo_partido.Text = "0" + Convert.ToString(_minutos) + ":" + Convert.ToString(_segundos);
            } else if(_minutos > 9 && _segundos < 10)
            {
                tiempo_partido.Text = Convert.ToString(_minutos) + ":0" + Convert.ToString(_segundos);
            } else
            {
                tiempo_partido.Text = Convert.ToString(_minutos) + ":" + Convert.ToString(_segundos);
            }
        }

        public void sumaSegundo()
        {
            _segundos++;

            if(_segundos == 60)
            {
                _segundos = 0;
                _minutos++;
            }
            cargarTiempoTranscurrido();
        }

        public void restaSegundo()
        {
            _segundos--;
            cargarTiempoTranscurrido();
        }

        public void sumaMinuto()
        {
            _minutos++;
            cargarTiempoTranscurrido();
        }

        public void restaMinuto()
        {
            _minutos--;
            cargarTiempoTranscurrido();
        }
    }
}