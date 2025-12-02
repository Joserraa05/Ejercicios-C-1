using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace WPF9_Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea() { name = "Complete this WPF tutorial", progress = 50 });
            tareas.Add(new Tarea() { name = "Learn C#", progress = 75 });
            tareas.Add(new Tarea() { name = "Wash the car", progress = 0 });
            Tareas.ItemsSource = tareas;
        }

        public class Tarea
        {
            public string name {  get; set; }
            public int progress { get; set; }
        }

        private void showSelected(object sender, RoutedEventArgs e)
        {

        }

        private void selectLast(object sender, RoutedEventArgs e)
        {
            
        }

        private void selectNext(object sender, RoutedEventArgs e)
        {

        }

        private void selectC(object sender, RoutedEventArgs e)
        {

        }

        private void selectAll(object sender, RoutedEventArgs e)
        {

        }
    }
}
