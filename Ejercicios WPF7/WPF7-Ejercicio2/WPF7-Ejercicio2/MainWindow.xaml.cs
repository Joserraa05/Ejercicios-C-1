using Microsoft.Win32;
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

namespace WPF7_Ejercicio2
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

        public void Imagen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png | *.png| jpeg | *.jpeg| jpg | *.jpg";
            if (ofd.ShowDialog() == true)
            {
                string rutaImagen = ofd.FileName;
                BitmapImage imagen = new BitmapImage(new Uri(rutaImagen));
                imagenCargada.Source = imagen; 
            }
        }
    }
}