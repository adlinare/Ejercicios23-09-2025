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

namespace Practica8Ejercicio1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FormData Data { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Data = new FormData();
            DataContext = Data;
        }

        private void btnIntroducir_Click(object sender, RoutedEventArgs e)
        {
            Window1 dlg = new Window1(Data.Email);

            if (dlg.ShowDialog() == true)
            {
                Data.Email = dlg.EmailValue;
            }
            txtResultado.Text = Data.Email;
        }
    }

    public class FormData
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
    }
}