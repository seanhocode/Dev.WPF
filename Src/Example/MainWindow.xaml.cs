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
}