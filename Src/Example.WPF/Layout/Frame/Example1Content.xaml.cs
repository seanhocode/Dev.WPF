using System.Windows.Controls;
using System.Windows;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Layout.Frame
{
    [Example("Layout/Frame", "Frame 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.Frame.Example1Definition))]
    public partial class Example1Content : UserControl
    {
        public Example1Content()
        {
            InitializeComponent();
        }

        private void GoToPage1(object sender, RoutedEventArgs e)
        {
            // Example1Frame: 於 XAML 中定義的 Frame 控制項名稱
            Example1Frame.Navigate(new Example1Page1());
        }

        private void GoToPage2(object sender, RoutedEventArgs e)
        {
            // Example1Frame: 於 XAML 中定義的 Frame 控制項名稱
            Example1Frame.Navigate(new Example1Page2());
        }
    }
}
