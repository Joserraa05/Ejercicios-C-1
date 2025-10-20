using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1_Ejercicio3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Margin = new Thickness(150);
            btn.FontWeight = FontWeights.Bold;
            btn.Content = "Botón con texto en bold";

            TextBlock tb1 = new TextBlock();
            tb1.Margin = new Thickness(10);
            tb1.Foreground = Brushes.Green;
            tb1.Text = "Bloque de texto verde";

            TextBlock tb2 = new TextBlock();
            tb2.Margin = new Thickness(40);
            tb2.Foreground = Brushes.Blue;
            tb2.Text = "Bloque de texto azul";

            TextBlock tb3 = new TextBlock();
            tb3.Margin = new Thickness(70);
            tb3.Text = "Bloque de texto sin formato";

            Grid1.Children.Add(btn);
            Grid1.Children.Add(tb1);
            Grid1.Children.Add(tb2);
            Grid1.Children.Add(tb3);
        }
    }
}