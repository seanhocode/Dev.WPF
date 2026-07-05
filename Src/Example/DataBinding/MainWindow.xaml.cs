using System.Windows;

namespace Example.DataBinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OpenDataContextsMainWindow(object sender, RoutedEventArgs e)
        {
            DataContexts.MainWindow dataContextsMainWindow = new DataContexts.MainWindow();
            dataContextsMainWindow.Show();
        }
    }
}
