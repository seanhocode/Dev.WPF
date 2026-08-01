using Example.WPF.Core.Model.DataBinding.DataContexts;
using Example.WPF.Infrastructure.Example.Attributes;
using Example.WPF.Core.Model.Definition.DataBinding.DependencyProperties;
using System.Windows.Controls;

namespace Example.WPF.DataBinding.DependencyProperties
{
    [Example("DataBinding/DependencyProperties", "基本範例",
             DefinitionType = typeof(Example1Definition))]
    public partial class Example1Window : UserControl
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
