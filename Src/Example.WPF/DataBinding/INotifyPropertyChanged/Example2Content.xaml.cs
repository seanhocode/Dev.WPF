using Example.WPF.Infrastructure.DataBinding.DataContexts;
using System.Windows;
using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.DataBinding.INotifyPropertyChanged
{
    [Example("DataBinding/INotifyPropertyChanged", "基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.DataBinding.INotifyPropertyChanged.Example2Definition))]
    public partial class Example2Content : UserControl
    {
        public Example2Content()
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
