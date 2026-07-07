using System.Windows;
using Example.WPF.Core.DataBinding.DataContexts;

namespace Example.WPF.DataBinding.DependencyProperties
{
    public partial class Example2Window : Window
    {
        public Example2Window()
        {
            InitializeComponent();

            FirstDataContext firstDataContext = new FirstDataContext();
            firstDataContext.FirstDataContextValue = 3.14159;

            this.DataContext = firstDataContext;
        }
    }
}
