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

namespace Practica8Ejercicio2
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

        private void SubOpcion11_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido Opción 1 → Subopción 1.1");
        }

        private void SubOpcion12_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido Opción 1 → Subopción 1.2");
        }

        private void SubOpcion13_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido Opción 1 → Subopción 1.3");
        }

        private void SubOpcion21_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido Opción 2 → Subopción 2.1");
        }

        private void SubOpcion22_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido Opción 2 → Subopción 2.2");
        }

        private void SubOpcion23_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido Opción 2 → Subopción 2.3");
        }
    }
}