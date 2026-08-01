using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Style
{
    [Example("Style", "Style 基本範例 3", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Style.Example3Definition))]
    public partial class Example3Content : UserControl
    {
        public Example3Content()
        {
            InitializeComponent();
        }
    }
}
