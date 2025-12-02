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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF11_Ejercicio4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Previous(object sender, RoutedEventArgs e)
        {
            Pestanias.SelectedIndex = Pestanias.SelectedIndex - 1;
        }

        private void Actual(object sender, RoutedEventArgs e)
        {
            TabItem t = Pestanias.SelectedItem as TabItem;
            Mensaje.Content = "Estás en la pestaña de " + t.Header;
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            Pestanias.SelectedIndex = Pestanias.SelectedIndex + 1;
        }
    }
}
