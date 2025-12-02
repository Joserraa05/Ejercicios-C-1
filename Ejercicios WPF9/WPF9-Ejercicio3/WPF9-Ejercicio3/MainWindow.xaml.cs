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

namespace WPF9_Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario() { id = 1, name = "Paco", edad = 34, trabajo = "Repostero" });
            usuarios.Add(new Usuario() { id = 2, name = "Pedro", edad = 54, trabajo = "Alabañil" });
            usuarios.Add(new Usuario() { id = 3, name = "Luis", edad = 24, trabajo = "Taxista" });
            usuario.ItemsSource = usuarios;
        }

        public class Usuario
        {
            public int id { get; set; }
            public string name { get; set; }
            public int edad { get; set; }
            public string trabajo { get; set; }
        }
    }
}
