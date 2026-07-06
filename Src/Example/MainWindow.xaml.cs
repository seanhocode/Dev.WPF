using System.Windows;

namespace Example.WPF;

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

    public void OpenXAMLExampleWindow(object sender, RoutedEventArgs e)
    {
        var xamlExampleMainWindow = new XAML.MainWindow();
        xamlExampleMainWindow.Show();
    }

    public void OpenResourceExampleWindow(object sender, RoutedEventArgs e)
    {
        var resourceExampleMainWindow = new Resource.MainWindow();
        resourceExampleMainWindow.Show();
    }

    public void OpenAttachedPropertyExampleWindow(object sender, RoutedEventArgs e)
    {
        var attachedPropertyExampleMainWindow = new AttachedProperty.MainWindow();
        attachedPropertyExampleMainWindow.Show();
    }

    public void OpenMarkupExtensionsExampleWindow(object sender, RoutedEventArgs e)
    {
        var markupExtensionsExampleMainWindow = new MarkupExtensions.MainWindow();
        markupExtensionsExampleMainWindow.Show();
    }

    public void OpenDataBindingExampleWindow(object sender, RoutedEventArgs e)
    {
        var dataBindingExampleMainWindow = new DataBinding.MainWindow();
        dataBindingExampleMainWindow.Show();
    }
}