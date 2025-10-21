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

namespace EjercicioWPF1_7
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
        private void Icono_Click(object sender, RoutedEventArgs e)
        {

            string nombre = txtNombre.SelectedText;

            if (string.IsNullOrEmpty(nombre))
                MessageBox.Show("Por favor, selecciona algo antes de pulsar el botón.");
            else
                MessageBox.Show($"Hola, {nombre}!");
        }
    }
}