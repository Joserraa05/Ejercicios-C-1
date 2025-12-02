using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace WPF10_Enercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] matriz;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void IniMatriz(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            int size = int.Parse(Input.Text);
            matriz = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                { 
                    matriz[i, j] = rd.Next(10);
                }
            }
        }

        private void ImpMatriz(object sender, RoutedEventArgs e)
        {
            int size = int.Parse(Input.Text);
            String res = "";

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    res = res + "\t" + matriz[i, j];
                }
                res = res + "\n";
            }

            Resultado.Text = res;
        }

        private void ImpTraspuesta(object sender, RoutedEventArgs e)
        {
            int size = int.Parse(Input.Text);
            String res = "";

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    res = res + "\t" + matriz[j, i];
                }
                res = res + "\n";
            }

            Resultado.Text = res;
        }
    }
}
