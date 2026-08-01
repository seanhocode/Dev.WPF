using Example.WPF.Core.Model.DataBinding.DataContexts;
using System.Windows;
using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.DataBinding.INotifyPropertyChanged
{
    [Example("DataBinding/INotifyPropertyChanged", "基本範例")]
    public partial class Example2Window : UserControl
    {
        public Example2Window()
        {
            InitializeComponent();
            INotifyPropertyChangedDataContext inotifyPropertyChangedDataContext = new INotifyPropertyChangedDataContext();
            inotifyPropertyChangedDataContext.INotifyPropertyChangedDataContextValue = 0;
            this.DataContext = inotifyPropertyChangedDataContext;
        }

        public void AddOne(object sender, RoutedEventArgs e)
        {
            INotifyPropertyChangedDataContext inotifyPropertyChangedDataContext = this.DataContext as INotifyPropertyChangedDataContext ?? new INotifyPropertyChangedDataContext();
            inotifyPropertyChangedDataContext.INotifyPropertyChangedDataContextValue++;
        }
    }
}
