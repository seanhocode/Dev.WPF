using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Layout.Grid
{
    [Example("Layout/Grid", "Grid 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.Grid.Example1Definition))]
    public partial class Example1Content : UserControl
    {
        public Example1Content()
        {
            InitializeComponent();
        }
    }
}
