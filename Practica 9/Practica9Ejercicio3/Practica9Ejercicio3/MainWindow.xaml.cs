using System.Collections.ObjectModel;
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

namespace Practica9Ejercicio3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> Users { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Users = new ObservableCollection<User>();

            AddSampleData();

            DataListView.ItemsSource = Users;
        }

        private void AddSampleData()
        {
            Users.Add(new User("Elena Ríos", 29, "Valencia", new DateTime(2023, 11, 20)));
            Users.Add(new User("Marcos Soto", 45, "Sevilla", new DateTime(2022, 05, 12)));
            Users.Add(new User("Carmen López", 19, "Málaga", new DateTime(2024, 01, 01)));
            Users.Add(new User("David Gómez", 33, "Bilbao", new DateTime(2023, 08, 28)));
        }
    }
}