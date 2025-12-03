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

namespace Practica11Ejercicio4ç
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

        private void BtnAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (TabControlPrincipal.SelectedIndex > 0)
            {
                 TabControlPrincipal.SelectedIndex--;
            }

        }

        private void BtnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (TabControlPrincipal.SelectedIndex < TabControlPrincipal.Items.Count - 1)
            {
                 TabControlPrincipal.SelectedIndex++;
            }

        }

        private void BtnSeleccionado_Click(object sender, RoutedEventArgs e)
        {
            TabItem selectedTab = TabControlPrincipal.SelectedItem as TabItem;

            if (selectedTab != null)
            {
                string tabName = selectedTab.Header.ToString();

                MessageBox.Show($"Has seleccionado la opción de {tabName}",
                                "Opción Seleccionada",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }

        }

        
       
    }
}