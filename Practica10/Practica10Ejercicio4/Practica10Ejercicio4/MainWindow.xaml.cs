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

namespace Practica10Ejercicio4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Empleado[] empleados = new Empleado[10];
        private int contadorEmpleados = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHoraExtra_Click(object sender, RoutedEventArgs e)
        {
            if (contadorEmpleados == 0)
            {
                MessageBox.Show("No hay empleados registrados.");
                return;
            }
            else
            {
                InputHoraExtra inputHorasExtraWindow = new InputHoraExtra();
                bool? reult = inputHorasExtraWindow.ShowDialog();
                if (reult == true)
                {
                    string nombreEmpleado = inputHorasExtraWindow.NombreEmpleado;
                    int horasExtra = inputHorasExtraWindow.HorasExtra;
                    bool empleadoEncontrado = false;
                    for (int i = 0; i < contadorEmpleados; i++)
                    {
                        if (empleados[i].Nombre == nombreEmpleado)
                        {
                            empleados[i].HaceHorasExtra(horasExtra);
                            empleadoEncontrado = true;
                            MessageBox.Show("Horas extra agregadas correctamente.");
                            break;
                        }
                    }
                    if (!empleadoEncontrado)
                    {
                        MessageBox.Show("Empleado no encontrado.");
                    }
                }
            }



        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (iniciosesion())
            {
                AltaEmpleado altaEmpleadoWindow = new AltaEmpleado();
                bool? result = altaEmpleadoWindow.ShowDialog();
                if (result == true)
                {
                    if (contadorEmpleados < empleados.Length)
                    {
                        string nombre = altaEmpleadoWindow.NombreEmpleado;
                        decimal salario = altaEmpleadoWindow.SalarioEmpleado;
                        empleados[contadorEmpleados] = new Empleado(nombre, salario);
                        contadorEmpleados++;
                        MessageBox.Show("Empleado agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pueden agregar más empleados. Capacidad máxima alcanzada.");
                    }
                }
            }
        }

        private void btnShowHorasExtra_Click(object sender, RoutedEventArgs e)
        {
            if (iniciosesion())
            {
                if (contadorEmpleados == 0)
                {
                    MessageBox.Show("No hay empleados registrados.");
                    return;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    int sumaHorasExtra = 0;
                    for (int i = 0; i < contadorEmpleados; i++)
                    {
                        if (empleados[i].HorasExtra > 0)
                        {
                            sumaHorasExtra += empleados[i].HorasExtra;
                        }
                    }
                    sb.AppendLine("Horas Extra totales:" + sumaHorasExtra);
                    txtOutput.Text = sb.ToString();

                }
            }

        }

        private void btnInforme_Click(object sender, RoutedEventArgs e)
        {
            if (iniciosesion())
            {
                if (contadorEmpleados == 0)
                {
                    MessageBox.Show("No hay empleados registrados.");
                    return;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Empleados:");
                    for (int i = 0; i < contadorEmpleados; i++)
                    {
                        sb.AppendLine($"{empleados[i].Nombre}:{empleados[i].Salario} salario sin horas extra, {empleados[i].HorasExtra} horas extra, {empleados[i].CalcularSalario()} salario total");
                    }
                    txtOutput.Text = sb.ToString();
                }
            }
            

        }

        public bool iniciosesion()
        {
            InputInicioSesion inicio = new InputInicioSesion();
            bool? result = inicio.ShowDialog();
            if (result == true)
            {
                if (inicio.Password == "1234")
                {
                    return true;
                }
                else
                {
                    txtOutput.Text = "Contraseña incorrecta";
                    return false;
                }
            }
            return false;
        }

    }
}