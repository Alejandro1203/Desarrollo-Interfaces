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
using System.Windows.Shapes;

namespace Cuentarrevoluciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int revoluciones = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Acelerar_Click(object sender, RoutedEventArgs e)
        {
            revoluciones += 21;
            label_Revoluciones.Content = revoluciones.ToString();

            rotaFlecha.Angle += 0.6;
        }
    }
}
