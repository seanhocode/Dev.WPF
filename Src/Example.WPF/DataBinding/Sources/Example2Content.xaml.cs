using Example.WPF.Infrastructure.Example.Attributes;
using System.Windows.Controls;

namespace Example.WPF.DataBinding.Sources
{
    [Example("DataBinding/Source", "ElementName 範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.DataBinding.Sources.Example2Definition))]
    public partial class Example2Content : UserControl
    {
        public Example2Content()
        {
            InitializeComponent();
        }
    }
}
