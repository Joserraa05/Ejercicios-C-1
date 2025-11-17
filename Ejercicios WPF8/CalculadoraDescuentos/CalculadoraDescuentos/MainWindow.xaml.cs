using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace CalculadoraDescuentos
{
    /// <summary>
    /// Lógica de interacción para PrecioFinal.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Calcular(object sender, RoutedEventArgs e)
        {
            double precio = 0;

            if (string.IsNullOrEmpty(Precio.Text) || !double.TryParse(Precio.Text, out precio) || Precio.Text.Contains("."))
            {
                MessageBox.Show("El campo del precio no debe estar vacío y deben ser números");
                Precio.Text = "";
                return;
            }

            if (diez.IsChecked == true)
            {
                PrecioFinal precioFinal = new PrecioFinal(precio, 10);
                precioFinal.ShowDialog();
            }
            else if (veinte.IsChecked == true)
            {
                PrecioFinal precioFinal = new PrecioFinal(precio, 20);
                precioFinal.ShowDialog();
            }
            else if (treinta.IsChecked == true)
            {
                PrecioFinal precioFinal = new PrecioFinal(precio, 30);
                precioFinal.ShowDialog();
            }
            else if (cuarenta.IsChecked == true)
            {
                PrecioFinal precioFinal = new PrecioFinal(precio, 40);
                precioFinal.ShowDialog();
            }
            else if (cincuenta.IsChecked == true)
            {
                PrecioFinal precioFinal = new PrecioFinal(precio, 50);
                precioFinal.ShowDialog();
            }
            else MessageBox.Show("Debe seleccionar un porcentaje de descuento");
        }
    }
}