using System.Reflection;
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

namespace Practica9Ejercicio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadColorsToComboBox(); 
        }

        private void LoadColorsToComboBox()
        {
            PropertyInfo[] colorProperties = typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static);

            foreach (PropertyInfo property in colorProperties)
            {
                ColorComboBox.Items.Add(property.Name);
            }
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null && comboBox.SelectedItem is string selectedColorName)
            {
                try
                {
                    Color selectedColor = (Color)ColorConverter.ConvertFromString(selectedColorName);

                    SolidColorBrush newBrush = new SolidColorBrush(selectedColor);

                    this.Background = newBrush;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al aplicar el color: {ex.Message}", "Error de Color", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}