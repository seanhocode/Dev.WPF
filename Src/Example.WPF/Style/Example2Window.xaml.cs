using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Style
{
    [Example("Style", "Style 基本範例 2", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Style.Example2Definition))]
    public partial class Example2Window : UserControl
    {
        public Example2Window()
        {
            InitializeComponent();
        }
    }
}
