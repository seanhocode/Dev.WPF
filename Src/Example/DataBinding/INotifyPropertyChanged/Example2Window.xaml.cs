using Example.WPF.Core.DataBinding.DataContexts;
using System.Windows;

namespace Example.WPF.DataBinding.INotifyPropertyChanged
{
    public partial class Example2Window : Window
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
