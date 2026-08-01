using Example.WPF.Infrastructure.Example.Attributes;
using System.Windows.Controls;

namespace Example.WPF.Layout.Canvas
{
    [Example("Layout/Canvas", "Canvas 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.Canvas.Example1Definition))]
    public partial class Example1Window : UserControl
    {
        public Example1Window()
        {
            InitializeComponent();
        }
    }
}
