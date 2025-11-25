using Microsoft.Win32;
using System.IO;
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

namespace Practica8Ejercicio3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Vinculación de comandos al TextBox
            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.New, Nuevo_Executed));

            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Cut, Cut_Executed, Cut_CanExecute));

            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Copy, Copy_Executed, Copy_CanExecute));

            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Paste, Paste_Executed, Paste_CanExecute));
        }

        // =============================
        //        EVENTO GUARDAR
        // =============================
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Archivo de texto (*.txt)|*.txt";

            if (dlg.ShowDialog() == true)
            {
                File.WriteAllText(dlg.FileName, txtEditor.Text);
                MessageBox.Show("Archivo guardado correctamente.",
                                "Guardar",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }

        // =============================
        //         COMANDO NUEVO
        // =============================
        private void Nuevo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Clear();
        }

        // =============================
        //         COMANDO CORTAR
        // =============================
        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Cut();
        }

        private void Cut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtEditor.SelectionLength > 0;
        }

        // =============================
        //         COMANDO COPIAR
        // =============================
        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Copy();
        }

        private void Copy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtEditor.SelectionLength > 0;
        }

        // =============================
        //         COMANDO PEGAR
        // =============================
        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Paste();
        }

        private void Paste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }
    }
}