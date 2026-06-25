using System.Windows;

namespace Example.Layout.Grid
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

        public void OpenExample2Window(object sender, RoutedEventArgs e)
        {
            Example2Window example2Window = new Example2Window();
            example2Window.Show();
        }

        public void OpenExample3Window(object sender, RoutedEventArgs e)
        {
            Example3Window example3Window = new Example3Window();
            example3Window.Show();
        }
    }
}
