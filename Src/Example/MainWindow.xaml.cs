using System.Windows;

namespace Example;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void OpenLayoutExampleWindow(object sender, RoutedEventArgs e)
    {
        var layoutExampleMainWindow = new Layout.MainWindow();
        layoutExampleMainWindow.Show();
    }

    public void OpenStyleExampleWindow(object sender, RoutedEventArgs e)
    {
        var styleExampleMainWindow = new Style.MainWindow();
        styleExampleMainWindow.Show();
    }

    public void OpenTemplateExampleWindow(object sender, RoutedEventArgs e)
    {
        var templateExampleMainWindow = new Template.MainWindow();
        templateExampleMainWindow.Show();
    }
}