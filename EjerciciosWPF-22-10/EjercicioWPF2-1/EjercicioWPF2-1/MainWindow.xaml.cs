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

namespace EjercicioWPF2_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int intentosRestantes = 2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCorregir_Click(object sender, RoutedEventArgs e)
        {
            if (intentosRestantes <= 0)
            {
                MessageBox.Show("Ya no te quedan intentos.", "Fin de intentos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            intentosRestantes--;

            if (rbtnKotlin.IsChecked == true)
            {
                MessageBox.Show("¡Correcto! Kotlin es el lenguaje oficial para Android.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                btnCorregir.IsEnabled = false;
            }
            else
            {
                if (intentosRestantes > 0)
                    MessageBox.Show($"Incorrecto. Te quedan {intentosRestantes} intento(s).", "Resultado", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    MessageBox.Show("Has agotado todos los intentos.", "Resultado", MessageBoxButton.OK, MessageBoxImage.Warning);
                    btnCorregir.IsEnabled = false;
                }
            }

            lblIntentos.Content = $"Intentos restantes: {intentosRestantes}";
        }
    }
}