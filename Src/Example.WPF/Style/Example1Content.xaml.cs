using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Style
{
    [Example("Style", "Style 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Style.Example1Definition))]
    public partial class Example1Content : UserControl
    {
        public Example1Content()
        {
            InitializeComponent();
        }
    }
}
