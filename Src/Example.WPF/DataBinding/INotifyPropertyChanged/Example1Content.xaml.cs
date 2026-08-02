using Example.WPF.Infrastructure.DataBinding.DataContexts;
using Example.WPF.Infrastructure.Example.Attributes;
using System.Windows;
using System.Windows.Controls;

namespace Example.WPF.DataBinding.INotifyPropertyChanged
{
    [Example("DataBinding/INotifyPropertyChanged", "無效設定範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.DataBinding.INotifyPropertyChanged.Example1Definition))]
    public partial class Example1Content : UserControl
    {
        public Example1Content()
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
