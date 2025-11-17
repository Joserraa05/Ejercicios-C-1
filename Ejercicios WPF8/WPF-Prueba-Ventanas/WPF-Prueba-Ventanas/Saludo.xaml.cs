using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Prueba_Ventanas
{
    /// <summary>
    /// Lógica de interacción para Saludo.xaml
    /// </summary>
    public partial class Saludo : Window
    {
        public Saludo(string texto)
        {
            InitializeComponent();
            Hola.Text = "Buenas tardes " + texto;
        }
    }
}
