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

namespace WPF12_Ejercicio1
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

        private void CambioPest(object sender, SelectionChangedEventArgs e)
        {
            if (Tab2.IsSelected)
            {
                if (txtValor1.Text.Length > 0 && txtValor2.Text.Length > 0)
                {
                    Resultado.Text = "" + (double.Parse(txtValor1.Text) * double.Parse(txtValor2.Text));
                }
                else
                {
                    Tab1.IsSelected = true;
                    MessageBox.Show("Alguno de los campos de la primera pestaña está vacío");
                    
                }
            }
        }
    }
}
