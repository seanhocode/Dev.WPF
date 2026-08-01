using Example.WPF.Infrastructure.Example.Attributes;
using System.Windows.Controls;

namespace Example.WPF.DataBinding.DependencyProperties
{
    [Example("DataBinding/DependencyProperties", "錯誤範例(載入此範例會崩潰)", DefinitionType = typeof(Example.WPF.Core.Model.Definition.DataBinding.DependencyProperties.ErrorExample1Definition))]
    public partial class ErrorExample1Window : UserControl
    {
        public ErrorExample1Window()
        {
            InitializeComponent();
        }
    }
}
