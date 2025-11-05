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

namespace EjercicioWPF6_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string email = txtEmail.Text.Trim();
            string mensaje = txtMensaje.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de enviar.",
                                "Campos incompletos",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                return;
            }

            string texto = $"El usuario {nombre} con email {email} envía el mensaje:\n\n{mensaje}";
            MessageBox.Show(texto,
                            "Mensaje enviado correctamente",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }
    }
}
