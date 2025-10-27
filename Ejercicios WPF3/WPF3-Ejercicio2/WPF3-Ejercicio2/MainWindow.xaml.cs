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
using static System.Net.Mime.MediaTypeNames;

namespace WPF3_Ejercicio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cont = 2;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnCorregir(Object sender, RoutedEventArgs e)
        {
            if (cont == 0)
            {
                MessageBox.Show("No tienes más intentos");
                return;
            }

            if (rbA.IsChecked == true)
            {
                MessageBox.Show("Respuesta correcta!!!");
            }
            else
            {
                cont--;
                MessageBox.Show("Respuesta incorrecta :(\nTe quedan " + cont + " intentos");
            }
        }
    }
}