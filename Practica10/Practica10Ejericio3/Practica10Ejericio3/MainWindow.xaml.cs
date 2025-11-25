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

namespace Practica10Ejericio3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> tareas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTareaButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new DataEntruDialog();

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                if (tareas == null)
                {
                    tareas = new List<string>();
                }
                tareas.Add(dialog.Descripcion);
                UpdateTareasListBox();
            }
        }

        private void UpdateTareasListBox()
        {
            string result = "Las tareas pendientes son:\n\n";
            if (tareas != null){
                foreach (var tarea in tareas)
                {
                    result += "- " + tarea + "\n";
                }
                
            }
            OutputTextBlock.Text = result;

        }


        private void DoNext_Click(object sender, RoutedEventArgs e)
        {
            if (tareas != null)
            {
                MessageBox.Show("Se ha marcado como completada la sigueinte tarea: " + tareas[0]);
                tareas.RemoveAt(0);
                if (tareas.Count == 0)
                {
                    tareas = null;
                }
                UpdateTareasListBox();
            }
            else
            {
                MessageBox.Show("No hay tareas pendientes.");
            }
        }


        private void ShowPending_Click(object sender, RoutedEventArgs e)
        {
            if (tareas != null)
            {
                StringBuilder pendingTasks = new StringBuilder("Las tareas pendientes son:\n\n");
                foreach (var tarea in tareas)
                {
                    pendingTasks.AppendLine("- " + tarea);
                }
                MessageBox.Show(pendingTasks.ToString());
            }
            else
            {
                MessageBox.Show("No hay tareas pendientes.");

            }
        }


        private void ShowNumber_Click(object sender, RoutedEventArgs e)
        {
            if(tareas != null)
            {
                MessageBox.Show("El número de tareas pendientes es: " + tareas.Count);
            }
            else
            {
                MessageBox.Show("No hay tareas pendientes.");
            }

        }

        private void ShowNext_Click(object sender, RoutedEventArgs e)
        {
            if(tareas != null)
            {
                MessageBox.Show("La siguiente tarea es: " + tareas[0]);
            }
            else
            {
                MessageBox.Show("No hay tareas pendientes.");
            }

        }
    }
}