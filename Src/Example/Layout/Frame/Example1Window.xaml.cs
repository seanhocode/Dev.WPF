using System.Windows;

namespace Example.Layout.Frame
{
    public partial class Example1Window : Window
    {
        public Example1Window()
        {
            InitializeComponent();
        }

        private void GoToPage1(object sender, RoutedEventArgs e)
        {
            // Example1Frame: 於 XAML 中定義的 Frame 控件名稱
            Example1Frame.Navigate(new Example1Page1());
        }

        private void GoToPage2(object sender, RoutedEventArgs e)
        {
            // Example1Frame: 於 XAML 中定義的 Frame 控件名稱
            Example1Frame.Navigate(new Example1Page2());
        }
    }
}
