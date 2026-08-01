using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Layout.ViewBox
{
    [Example("Layout/ViewBox", "ViewBox 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.ViewBox.Example1Definition))]
    public partial class Example1Content : UserControl
    {
        public Example1Content()
        {
            InitializeComponent();
        }
    }
}
