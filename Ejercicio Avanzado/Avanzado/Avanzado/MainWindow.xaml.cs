using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Avanzado
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
            UserListBox.ItemsSource = Users;

            Users.Add(new User("Manuel Garcia", 35));
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            Window1 addUserWindow = new Window1();

            bool? result = addUserWindow.ShowDialog();

            if (result == true)
            {
                User newUser = addUserWindow.NewUser;

                if (newUser != null)
                {
                    Users.Add(newUser);
                }
                else
                {
                    MessageBox.Show("Error al recibir los datos del nuevo usuario.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}