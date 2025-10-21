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

namespace EjercicioWPF1_5
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
        private void txtEntrada_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string seleccionado = txtEntrada.SelectedText;

            if (string.IsNullOrEmpty(seleccionado))
                txtSeleccion.Text = "Has seleccionado...";
            else
                txtSeleccion.Text = $"Has seleccionado \"{seleccionado}\"";
        }
    }
}