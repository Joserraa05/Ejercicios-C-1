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

namespace WPF11_Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cont = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cambio1(object sender, RoutedEventArgs e)
        {
            Btn1.BorderBrush = new SolidColorBrush(cambiarColor());
        }

        private void Cambio2(object sender, RoutedEventArgs e)
        {
            Btn2.BorderBrush = new SolidColorBrush(cambiarColor());
        }

        private void Cambio3(object sender, RoutedEventArgs e)
        {
            Btn3.BorderBrush = new SolidColorBrush(cambiarColor());
        }

        public Color cambiarColor()
        {
            Color[] colores = {
                Colors.White,
                Colors.Violet,
                Colors.Red,
                Colors.Blue,
                Colors.Green,
                Colors.Yellow,
                Colors.Orange,
                Colors.Pink,
                Colors.Brown,
                Colors.Gray,
                Colors.Cyan,
                Colors.Magenta
            };

            cont++;
            return colores[cont];
        }
    }
}
