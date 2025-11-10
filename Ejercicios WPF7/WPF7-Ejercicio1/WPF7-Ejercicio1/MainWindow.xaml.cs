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

namespace WPF7_Ejercicio1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Simple(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje simple");
        }

        public void Title(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje con titulo", "Titulo del mensaje");
        }

        public void Buttons(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje con botones", "", MessageBoxButton.YesNoCancel);
        }

        public void Response(object sender, RoutedEventArgs e)
        {
            var respuesta = MessageBox.Show("Mensaje con respuesta", "", MessageBoxButton.YesNo);
            switch (respuesta)
            {
                case MessageBoxResult.Yes: 
                    MessageBox.Show("Le has dado a yes");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Le has dado a no");
                    break;
            }
        }

        public void Icon(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje con icono", "", MessageBoxButton.OK, MessageBoxImage.Hand);
        }

        public void Default(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje con no seleccionado por defecto", "", MessageBoxButton.YesNoCancel, MessageBoxImage.Hand, MessageBoxResult.No);
        }
    }
}