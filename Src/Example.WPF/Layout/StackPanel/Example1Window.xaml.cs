using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Layout.StackPanel
{
    [Example("Layout/StackPanel", "StackPanel 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.StackPanel.Example1Definition))]
    public partial class Example1Window : UserControl
    {
        public Example1Window()
        {
            InitializeComponent();
        }
    }
}
