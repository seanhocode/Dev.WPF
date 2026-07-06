using System.Windows;

namespace Example.WPF.Layout.ViewBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OpenExample1Window(object sender, RoutedEventArgs e)
        {
            Example1Window example1Window = new Example1Window();
            example1Window.Show();
        }
    }
}
