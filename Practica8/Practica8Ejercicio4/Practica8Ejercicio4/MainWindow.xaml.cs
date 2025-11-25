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

namespace Practica8Ejercicio4
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

        // CORTAR
        private void Cortar_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Cut();
        }

        // COPIAR
        private void Copiar_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Copy();
        }

        // PEGAR
        private void Pegar_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Paste();
        }

        // MOSTRAR (MessageBox con título e icono)
        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            string seleccionado = txtEditor.SelectedText;

            if (string.IsNullOrWhiteSpace(seleccionado))
            {
                MessageBox.Show(
                    "No hay texto seleccionado.",
                    "Mostrar",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show(
                    seleccionado,
                    "Texto seleccionado",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
        }
    }
}
