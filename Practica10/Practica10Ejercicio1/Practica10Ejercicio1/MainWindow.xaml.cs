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

namespace Practica10Ejercicio1
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

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                
                try
                {
                    string inputText = InputTextBox.Text;
                    if (inputText.Length != 8)
                    {
                        throw new Exception();
                    }
                    
                    char[] Values = ['T','R','W','A','G','M','Y','F','P', 'D','X','B']; 

                    int dniNumber = int.Parse(inputText);

                    int index = dniNumber % 23;

                    string result = string.Format("La letra del DNI es la {0}", Values[index]);
                    ResultTextBlock.Text = result;
                } catch (System.Exception ex)
                {
                    MessageBox.Show("ERROR: Debe introducir un numero valido ");
                }
            }

        }
    }
}