using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practica11Ejercicio1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnOscuro_Click(object sender, RoutedEventArgs e)
        {

            BorderOscuro.Background = new SolidColorBrush(Colors.Black);
        }

        private void btnClaro_Click(object sender, RoutedEventArgs e)
        {

            BorderOscuro.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void btnVerde_Click(object sender, RoutedEventArgs e)
        {


            BorderOscuro.Background = new SolidColorBrush(Colors.Green);
        }
    }
}