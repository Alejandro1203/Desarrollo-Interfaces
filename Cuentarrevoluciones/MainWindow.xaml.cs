using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Cuentarrevoluciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num = 0;
        private int _revoluciones = 0;
        private const int REVOL_MIN_STOP = 0;
        private const int REVOL_MIN_START = 1000;
        private const int REVOL_MAX = 9000;
        private const int REVOL_START = 1000;
        private const double ANGLE_MIN = -43.991;
        private const double ANGLE_MAX = 223.367;
        private const double ANGLE_START = -15.41957142857143;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void setRevol()
        {
            label_Revoluciones.Content = _revoluciones.ToString();
        }

        private void button_Acelerar_Click(object sender, RoutedEventArgs e)
        {
            num += 0.01;

            if(_revoluciones <= REVOL_MAX)
            {
                switch (desplegable_cv.SelectedIndex)
                {
                    case 0:
                        opacityMask.StartPoint = new Point(1, 1- num);   
                        _revoluciones += 42;
                        setRevol();
                        rotaFlecha.Angle += 1.25;
                        break;

                    case 1:
                        _revoluciones += 84;
                        setRevol();
                        rotaFlecha.Angle += 2.5;
                        break;

                    case 2:
                        _revoluciones += 126;
                        setRevol();
                        rotaFlecha.Angle += 3.75;
                        break;
                }
                
            } else
            {
                label_Revoluciones.Content = 9000.ToString();
            }
        }

        private void button_Freno_Click(object sender, RoutedEventArgs e)
        {
            if (_revoluciones > REVOL_MIN_START)
            {
                switch (desplegable_cv.SelectedIndex)
                {
                    case 0:
                        _revoluciones -= 42;
                        setRevol();
                        rotaFlecha.Angle -= 1.25;
                        break;

                    case 1:
                        _revoluciones -= 84;
                        setRevol();
                        rotaFlecha.Angle -= 2.5;
                        break;

                    case 2:
                        _revoluciones -= 126;
                        setRevol();
                        rotaFlecha.Angle -= 3.75;
                        break;
                }
            }
            else
            {
                label_Revoluciones.Content = 1000.ToString();
            }
        }

        private void img_strat_stop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Uri uri;
            StreamResourceInfo streamResourceInfo;

            if(_revoluciones != 0)
            {
                uri = new Uri("boton_apagado.png", UriKind.Relative);
                streamResourceInfo = Application.GetResourceStream(uri);
                img_strat_stop.Source = BitmapFrame.Create(streamResourceInfo.Stream);

                _revoluciones = REVOL_MIN_STOP;
                setRevol();
                rotaFlecha.Angle = ANGLE_MIN;
                button_Acelerar.IsEnabled = false;
                button_Freno.IsEnabled = false;
                desplegable_cv.IsEnabled = true;

            } else
            {
                uri = new Uri("boton_encendido.png", UriKind.Relative);
                streamResourceInfo = Application.GetResourceStream(uri);
                img_strat_stop.Source = BitmapFrame.Create(streamResourceInfo.Stream);

                _revoluciones = REVOL_START;
                setRevol();
                rotaFlecha.Angle = ANGLE_START;
                button_Acelerar.IsEnabled = true;
                button_Freno.IsEnabled = true;
                desplegable_cv.IsEnabled = false;
            }
        }
    }
}