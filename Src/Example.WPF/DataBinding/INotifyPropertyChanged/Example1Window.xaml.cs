using Example.WPF.Core.Model.DataBinding.DataContexts;
using System.Windows;

namespace Example.WPF.DataBinding.INotifyPropertyChanged
{
    public partial class Example1Window : Window
    {
        public Example1Window()
        {
            InitializeComponent();
            FirstDataContext firstDataContext = new FirstDataContext();
            firstDataContext.FirstDataContextValue = 0;

            this.DataContext = firstDataContext;
        }

        public void AddOne(object sender, RoutedEventArgs e)
        {
            FirstDataContext firstDataContext = this.DataContext as FirstDataContext ?? new FirstDataContext();
            firstDataContext.FirstDataContextValue++;
        }
    }
}
