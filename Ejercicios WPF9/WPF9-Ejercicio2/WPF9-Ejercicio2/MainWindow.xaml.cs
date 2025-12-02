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

namespace WPF9_Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbColors.Items.Clear();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        public void cambio(object sender, SelectionChangedEventArgs e)
        {
            if (cmbColors.SelectedItem is System.Reflection.PropertyInfo pinfo)
            {
                Ventana.Background = new SolidColorBrush((Color)pinfo.GetValue(null));
            }
        }
    }
}
