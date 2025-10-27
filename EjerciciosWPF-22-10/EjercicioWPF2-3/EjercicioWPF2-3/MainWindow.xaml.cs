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

namespace EjercicioWPF2_3
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Password;

            
            string usuarioCorrecto = "admin";
            string passwordCorrecto = "1234";

            if (usuario == usuarioCorrecto && password == passwordCorrecto)
            {
                MessageBox.Show("Inicio de sesión correcto. ¡Bienvenido!",
                                "Login exitoso",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                                "Error de autenticación",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }
    }
}