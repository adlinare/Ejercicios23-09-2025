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

namespace WPFEjercicio3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button bt = new Button();
            bt.FontWeight = FontWeights.Bold;
            bt.Height = 65;
            bt.Width = 90;
            bt.Content = new WrapPanel
            {
                Children =
                {
                    new TextBlock
                    {
                        Text = "Click me",
                        Foreground = Brushes.Green
                    },
                    new TextBlock
                    {
                        Text = "Click me",
                        Foreground = Brushes.Blue
                    },
                    new TextBlock
                    {
                        Text = "Click me"
                    }
                }
            };
            MainGridid.Children.Add(bt);

        }
    }
}