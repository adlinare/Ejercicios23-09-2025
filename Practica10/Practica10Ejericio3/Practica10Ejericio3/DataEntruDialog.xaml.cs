using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practica10Ejericio3
{
    /// <summary>
    /// Lógica de interacción para DataEntruDialog.xaml
    /// </summary>
    public partial class DataEntruDialog : Window
    {
        public string Descripcion { get; set; }
        public DataEntruDialog()
        {
            InitializeComponent();
        }

        private void ButtonAccept(object sender, RoutedEventArgs e)
        {
            this.Descripcion = DescriptionTextBox.Text;

            this.DialogResult = true;
        }

        private void ButtonCancel(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
