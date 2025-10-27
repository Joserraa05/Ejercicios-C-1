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

namespace WPF3_Ejercicio3
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

        public void btnLogin(Object sender, RoutedEventArgs e)
        {
            if (user.Text.Equals("usuario") && pass.Password.Equals("password"))
            {
                MessageBox.Show("Login correcto, accediedo a la aplicación...");
            }
            else MessageBox.Show("Usuario y contraseña incorrectos...");
        }
    }
}