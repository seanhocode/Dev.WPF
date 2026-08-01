using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Layout.DockPanel
{
    [Example("Layout/DockPanel", "DockPanel 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.DockPanel.Example1Definition))]
    public partial class Example1Window : UserControl
    {
        public Example1Window()
        {
            InitializeComponent();
        }
    }
}
