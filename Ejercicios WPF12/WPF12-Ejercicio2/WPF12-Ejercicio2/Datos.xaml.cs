using MySql.Data.MySqlClient;
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

namespace WPF12_Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para Datos.xaml
    /// </summary>
    public partial class Datos : Window
    {
        private readonly string connectionString = "Server=localhost; Port=3306; Database=prueba; Uid=root; Pwd=password";
        public Datos()
        {
            InitializeComponent();

            ResConsulta.Visibility = Visibility.Visible;

            StringBuilder resultados = new StringBuilder();
            resultados.AppendLine("\n-----Datos de Clientes----");

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT id, name FROM users";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string nombre = reader.GetString("name");

                                resultados.AppendLine($"ID: {id}, Nombre: {nombre}");
                            }

                        }
                    }

                    if (resultados.Length <= 0)
                    {
                        resultados.AppendLine("No se encontraron datos");
                    }

                    ResConsulta.Text = resultados.ToString();

                }
                catch (MySqlException ex)
                {
                    ResConsulta.Text = $"ERROR al contectar con la BBDD{ex.Message}";
                }
            }


        }
        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
