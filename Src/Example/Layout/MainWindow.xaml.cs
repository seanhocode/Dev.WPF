using System.Windows;

namespace Example.Layout
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OpenGridExampleWindow(object sender, RoutedEventArgs e)
        {
            var gridExampleMainWindow = new Grid.MainWindow();
            gridExampleMainWindow.Show();
        }
    }
}
