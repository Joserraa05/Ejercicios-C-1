using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace WPF6_Ejercicio4
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

        private void OpenCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de texto (*.txt) | *.txt";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dialog.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(dialog.FileName);
            }
        }
        private void SaveCommand_CanExecute(Object sender, CanExecuteRoutedEventArgs e)
        { e.CanExecute = txtEditor != null && !string.IsNullOrWhiteSpace(txtEditor.Text); }

        private void SaveCommand_Executed(Object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivos de texto (*.txt) | *.txt ";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, txtEditor.Text);
            }
        }
    }
}