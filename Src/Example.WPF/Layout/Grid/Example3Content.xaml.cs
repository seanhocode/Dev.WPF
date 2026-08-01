using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Layout.Grid
{
    [Example("Layout/Grid", "Grid 基本範例 3", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.Grid.Example3Definition))]
    public partial class Example3Content : UserControl
    {
        public Example3Content()
        {
            InitializeComponent();
        }
    }
}
