using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Layout.StackPanel
{
    [Example("Layout/StackPanel", "StackPanel 基本範例 2", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Layout.StackPanel.Example2Definition))]
    public partial class Example2Window : UserControl
    {
        public Example2Window()
        {
            InitializeComponent();
        }
    }
}
