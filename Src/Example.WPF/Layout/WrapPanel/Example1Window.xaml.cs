using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Layout.WrapPanel
{
[Example("Layout/WrapPanel", "WrapPanel 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.WrapPanel.Example1Definition))]
    public partial class Example1Window : UserControl
    {
        public Example1Window()
        {
            InitializeComponent();
        }
    }
}
