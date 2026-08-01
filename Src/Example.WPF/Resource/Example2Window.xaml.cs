using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Resource
{
    [Example("Resource", "Resource 基本範例 2", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Resource.Example2Definition))]
    public partial class Example2Window : UserControl
    {
        public Example2Window()
        {
            InitializeComponent();
        }
    }
}
