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
using System.Windows.Shapes;

namespace WPF10_Ejercicio4
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Continuar(object sender, RoutedEventArgs e)
        {
            if (User.Text == "eladmin" && Contra == "nolapuedesabe")
            {
                MainWindow m = new MainWindow(true);
                Close();
            }
            else MessageBox.Show("Contraseña incorrecta", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}