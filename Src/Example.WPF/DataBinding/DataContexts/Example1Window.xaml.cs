using Example.WPF.Infrastructure.Example.Attributes;
using System.Windows.Controls;

namespace Example.WPF.DataBinding.DataContexts
{
    [Example("DataBinding/DataContexts", "基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.DataBinding.DataContexts.Example1Definition))]
    public partial class Example1Window : UserControl
    {
        public Example1Window()
        {
            InitializeComponent();
        }
    }
}
