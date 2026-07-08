using System.Windows;
using Example.WPF.Core.DataBinding.DataContexts;

namespace Example.WPF.DataBinding.DependencyProperties
{
    public partial class Example1Window : Window
    {
        public Example1Window()
        {
            InitializeComponent();

            FirstDataContext firstDataContext = new FirstDataContext();
            firstDataContext.FirstDataContextValue = 3.14159;

            this.DataContext = firstDataContext;
        }
    }
}
