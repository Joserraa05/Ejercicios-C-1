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

namespace WPF1_Ejercicio6
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

        private void btn1(Object sender, RoutedEventArgs e)
        {
            try
            {
                int[] a = {1, 2};
                a[7] = 19;
            }
            catch 
            {
                MessageBox.Show("Se ha capturado el error del array");
            }
        }
    }
}