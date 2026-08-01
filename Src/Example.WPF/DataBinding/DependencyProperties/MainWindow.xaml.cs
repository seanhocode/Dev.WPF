using System.Windows;

namespace Example.WPF.DataBinding.DependencyProperties
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

        public void OpenErrorExample1Window(object sender, RoutedEventArgs e)
        {
            ErrorExample1Window errorExample1Window = new ErrorExample1Window();
            errorExample1Window.Show();
        }
    }
}
