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

namespace EjercicioWPF2_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool mostrandoPrimera = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, RoutedEventArgs e)
        {
            if (mostrandoPrimera)
            {
                imgPrincipal.Source = new BitmapImage(new Uri("Assets/imagen2.jpg", UriKind.Relative));
                mostrandoPrimera = false;
            }
            else
            {
                imgPrincipal.Source = new BitmapImage(new Uri("Assets/imagen1.jpg", UriKind.Relative));
                mostrandoPrimera = true;
            }
        }
    }
}