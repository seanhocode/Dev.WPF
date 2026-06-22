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

        public void OpenStackPanelExampleWindow(object sender, RoutedEventArgs e)
        {
            var stackPanelExampleMainWindow = new StackPanel.MainWindow();
            stackPanelExampleMainWindow.Show();
        }

        public void OpenWrapPanelExampleWindow(object sender, RoutedEventArgs e)
        {
            var wrapPanelExampleMainWindow = new WrapPanel.MainWindow();
            wrapPanelExampleMainWindow.Show();
        }

        public void OpenDockPanelExampleWindow(object sender, RoutedEventArgs e)
        {
            var dockPanelExampleMainWindow = new DockPanel.MainWindow();
            dockPanelExampleMainWindow.Show();
        }
        public void OpenCanvasExampleWindow(object sender, RoutedEventArgs e)
        {
            var canvasExampleMainWindow = new Canvas.MainWindow();
            canvasExampleMainWindow.Show();
        }
    }
}
