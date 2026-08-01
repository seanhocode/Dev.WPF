using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.Template
{
    [Example("Template", "Template 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.Template.Example1Definition))]
    public partial class Example1Window : UserControl
    {
        public Example1Window()
        {
            InitializeComponent();
        }
    }
}
