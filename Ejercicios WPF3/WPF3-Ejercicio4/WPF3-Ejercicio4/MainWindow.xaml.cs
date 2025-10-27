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

namespace WPF3_Ejercicio4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool mostrando = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void cambio(object sender, RoutedEventArgs e)
        {
            if (mostrando)
            {
                imagen.Source = new BitmapImage(new Uri("/alba-valenti-fanboy-persp.jpg", UriKind.Relative));
                mostrando = false;
            }
            else
            {
                imagen.Source = new BitmapImage(new Uri("/flat,750x,075,f-pad,750x1000,f8f8f8.jpg", UriKind.Relative));
                mostrando = true;
            }
            
        }
    }
}