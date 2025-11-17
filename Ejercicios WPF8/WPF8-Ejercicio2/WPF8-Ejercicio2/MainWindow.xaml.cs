using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF8_Ejercicio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Hola(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has hecho click en la opcion Hola");
        }

        public void Buenas(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has hecho click en la opcion Buenas");
        }

        public void QueTal(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has hecho click en la opcion Que tal");
        }

        public void Adios(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has hecho click en la opcion Adios");
        }

        public void NosVemos(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has hecho click en la opcion Nos vemos");
        }

        public void HastaLuego(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has hecho click en la opcion Hasta luego");
        }
    }
}