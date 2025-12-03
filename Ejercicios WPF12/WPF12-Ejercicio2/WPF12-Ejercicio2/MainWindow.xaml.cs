using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using MySql.Data.MySqlClient;

namespace WPF12_Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string connectionString = "Server=localhost; Port=3306; Database=prueba; Uid=root; Pwd=password";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Connection(object sender, RoutedEventArgs e)
        {
            ResConexion.Visibility = Visibility.Visible;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                ResConexion.Text = "Conexión con la base de datos creada correctamente";
            }
        }

        private void Data(object sender, RoutedEventArgs e)
        {
            Datos datos = new Datos();
            datos.Show();
        }
    }
}
