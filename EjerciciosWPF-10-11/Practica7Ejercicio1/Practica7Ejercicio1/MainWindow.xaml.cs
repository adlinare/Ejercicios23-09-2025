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

namespace Practica7Ejercicio1
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

        private void btnMostrarMensaje_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¡Hola, este es un mensaje de prueba!");

        }

        private void btnMensajeTitulo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¡Hola, este es un mensaje de prueba!", "Título del Mensaje");
        }

        private void btnMensajeBotones_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿Deseas continuar?", "Confirmación", MessageBoxButton.YesNoCancel);
        }

        private void btnMensajeRespuesta_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult respuesta = MessageBox.Show("¿Deseas guardar los cambios?", "Guardar Cambios", MessageBoxButton.YesNo);
            switch (respuesta)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Has elegido guardar los cambios.");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Has elegido no guardar los cambios.");
                    break;
            }
        }

        private void btnMensajeIcono_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¡Ha ocurrido un error!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void btnMensjeRespuestaDefecto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿Deseas eliminar este archivo?", "Eliminar Archivo", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
        }
    }
}