using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography;
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

namespace WPF7_Ejercicio3
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

        public void Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt | *.txt";
            if (ofd.ShowDialog() == true)
            {
                txt.Text = File.ReadAllText(ofd.FileName);
            }
        }

        public void Close(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt | *.txt";
            sfd.InitialDirectory = "C:\\Users\\alumno\\Documents";
            if (sfd.ShowDialog() == true)
            {
                File.WriteAllText(sfd.FileName, txt.Text);
            }
        }
    }
}