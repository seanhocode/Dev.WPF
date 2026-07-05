using System.Windows;

namespace Example.MarkupExtensions
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
    }
}
