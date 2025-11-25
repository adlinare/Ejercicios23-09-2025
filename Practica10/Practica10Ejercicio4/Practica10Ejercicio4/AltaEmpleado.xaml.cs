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

namespace Practica10Ejercicio4
{
    /// <summary>
    /// Lógica de interacción para AltaEmpleado.xaml
    /// </summary>
    public partial class AltaEmpleado : Window
    {
        public string NombreEmpleado
        {
            get { return txtNombre.Text; }
        }
        public decimal SalarioEmpleado
        {
            get { return decimal.Parse(txtSalario.Text); }
        }
        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {

            this.DialogResult = true;

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

            this.DialogResult = false;

        }
    }
}
