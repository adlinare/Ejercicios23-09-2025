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

namespace Practica10Ejericcio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[][] matrix;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            
            try
            {
                int size = int.Parse(input);
                matrix = new int[size][];
                for (int i = 0; i < size; i++)
                {
                    matrix[i] = new int[size];
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i][j] = new Random().Next(1, 100);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: Debe intorucir un tamaño correcto");
            }
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayMatrix(matrix);
        }

        private void TraspostButton_Click(object sender, RoutedEventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Error: Primero debe generar la matriz");
                return;
            }
            else
            {
                int[][] traspuesta = new int[matrix.Length][];
                for (int i = 0; i < matrix.Length; i++)
                {
                    traspuesta[i] = new int[matrix.Length];
                    for (int j = 0; j < matrix.Length; j++)
                    {
                        traspuesta[i][j] = matrix[j][i];
                    }
                }
                DisplayMatrix(traspuesta);
            }

        }
        public void DisplayMatrix(int[][] mat)
        {
            if (matrix == null)
            {
                MessageBox.Show("Error: Primero debe generar la matriz");
                return;
            }
            else { 
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        sb.Append(mat[i][j] + "\t");
                    }
                    sb.AppendLine();
                }
                OutputTextBox.Text = sb.ToString();
            }
        }
    }
}