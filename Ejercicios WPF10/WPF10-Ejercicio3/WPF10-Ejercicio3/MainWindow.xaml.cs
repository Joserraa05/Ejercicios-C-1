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

namespace WPF10_Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> tareas = new List<String>();

        public MainWindow()
        {
            InitializeComponent();
            tareas.Add("Estudiar");
            tareas.Add("Ver una serie en Netflix");
            tareas.Add("Jugar al PES");
        }

        private void NuevaTarea(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length > 0)
            {
                tareas.Add(Input.Text);
                Input.Clear();
                Texto.Text = "Tarea creada con éxito.";
            }
            else Texto.Text = "La tarea no se puede identificar.";
        }

        private void MostrarSiguiente(object sender, RoutedEventArgs e)
        {
            if (tareas.ToArray().Length > 0)
            {
                Texto.Text = "La siguiente tarea a realizar es: " + tareas[0];
            }
            else Texto.Text = "No hay mas tareas.";
        }

        private void RealizarSiguiente(object sender, RoutedEventArgs e)
        {
            if (tareas.ToArray().Length > 0)
            {
                Texto.Text = "Tarea " + tareas[0] + " realizada.";
                tareas.Remove(tareas[0]);
                
            }
            else Texto.Text = "No hay mas tareas.";
        }

        private void MostrarNumero(object sender, RoutedEventArgs e)
        {
            Texto.Text = "El número de tareas pendientes es: " + tareas.ToArray().Length;
        }

        private void MostrarPendiente(object sender, RoutedEventArgs e)
        {
            String s = "Las tareas pendientes son: \n\n";
            foreach (String t in tareas)
            {
                s += t + "\n";
            }
            Texto.Text = s;
        }
    }
}
