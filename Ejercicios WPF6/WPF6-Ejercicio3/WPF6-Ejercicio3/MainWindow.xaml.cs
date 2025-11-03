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

namespace WPF6_Ejercicio3
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

        public void Enviar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El usuario " + txtNombre.Text + " con email " + txtEmail.Text + " envía el mensaje " + txtMensaje.Text);
        }
    }
}