using System;
using System.Security.Cryptography;
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

namespace EjercicioWPF1_8
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
        private void chkTodos_Checked(object sender, RoutedEventArgs e)
        {
            chkDI.IsChecked = true;
            chkSGE.IsChecked = true;
            chkAD.IsChecked = true;
        }

        // Evento cuando se desmarca el principal
        private void chkTodos_Unchecked(object sender, RoutedEventArgs e)
        {
            chkDI.IsChecked = false;
            chkSGE.IsChecked = false;
            chkAD.IsChecked = false;
        }

        private void chkTodos_Indeterminate(object sender, RoutedEventArgs e)
        {
        }

      
        private void Modulo_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool di = chkDI.IsChecked == true;
            bool sge = chkSGE.IsChecked == true;
            bool ad = chkAD.IsChecked == true;

            int count = (di ? 1 : 0) + (sge ? 1 : 0) + (ad ? 1 : 0);

            if (count == 3)
                chkTodos.IsChecked = true;
            else if (count == 0)
                chkTodos.IsChecked = false;
            else
                chkTodos.IsChecked = null;
        }
    }
}