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

namespace WPF10_Ejercicio4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool admin = false;
        List<Empleado> eList = new List<Empleado>();        

        public MainWindow()
        {
            InitializeComponent();
            eList.Add(new Empleado("Luis", 1200));
            eList.Add(new Empleado("Pedro", 1400));
            eList.Add(new Empleado("Samuel", 1000));
            eList.Add(new Empleado("Juan", 1500));
            eList.Add(new Empleado("Paco", 2000));
        }

        public MainWindow(String t)
        {
        }

        public MainWindow(bool b)
        {
            if (b == true) admin = true;
            else admin = false;
        }

        private void Alta(object sender, RoutedEventArgs e)
        {
            Login();
            Texto v = new Texto();
            v.ShowDialog();
        }

        private void Total(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Informe(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void Insertar(object sender, RoutedEventArgs e)
        {

        }

        private void Login()
        {
            Login l = new Login();
            l.ShowDialog();
        }
    }
}