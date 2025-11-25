using System;
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

namespace Practica9Ejercicio1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Inicialización de la lista con datos
            Elements element1 = new Elements() { Name = "Complete this WPF tutorial", progress = 50 };
            Elements element2 = new Elements() { Name = "Learn C#", progress = 80 };
            Elements element3 = new Elements() { Name = "Wash the car", progress = 20 };

            lstItems.Items.Add(element1);
            lstItems.Items.Add(element2);
            lstItems.Items.Add(element3);
        }

        /// <summary>
        /// Muestra el nombre y progreso del elemento actualmente seleccionado.
        /// </summary>
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            // Usamos el patrón is Elements para comprobar que hay un elemento seleccionado
            // y que es del tipo correcto, extrayendo la variable 'selectedElement'
            if (lstItems.SelectedItem is Elements selectedElement)
            {
                MessageBox.Show($"Elemento seleccionado:\nNombre: {selectedElement.Name}\nProgreso: {selectedElement.progress}%",
                                "Detalles de la Selección");
            }
            else
            {
                // Si no hay nada seleccionado, mostramos un mensaje
                MessageBox.Show("Por favor, selecciona un elemento de la lista.", "Sin Selección");
            }
        }

        /// <summary>
        /// Selecciona el último elemento de la lista.
        /// </summary>
        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            int lastIndex = lstItems.Items.Count - 1;
            if (lastIndex >= 0)
            {
                lstItems.SelectedIndex = lastIndex;
                lstItems.ScrollIntoView(lstItems.SelectedItem);
            }
        }

        /// <summary>
        /// Selecciona el siguiente elemento en la lista, si existe.
        /// </summary>
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            int currentIndex = lstItems.SelectedIndex;

            if (currentIndex < lstItems.Items.Count - 1)
            {
                lstItems.SelectedIndex = currentIndex + 1;
                lstItems.ScrollIntoView(lstItems.SelectedItem);
            }
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            lstItems.SelectedItems.Clear();

            foreach (var item in lstItems.Items)
            {
                if (item is Elements element && element.Name == "Learn C#")
                {
                    lstItems.SelectedItem = item;
                    lstItems.ScrollIntoView(item);
                    return; 
                }
            }
            MessageBox.Show("El elemento 'Learn C#' no se encontró en la lista.", "Búsqueda Fallida");
        }

        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
            lstItems.SelectAll();
        }
    }

    public class Elements
    {
        public String Name { get; set; }
        public int progress { get; set; }

        public override string ToString()
        {
            return $"{Name} ({progress}%)";
        }
    }
}