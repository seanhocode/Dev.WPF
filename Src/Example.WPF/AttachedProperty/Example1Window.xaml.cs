using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.AttachedProperty
{
    [Example("AttachedProperty", "AttachedProperty 基本範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.AttachedProperty.Example1Definition))]
    public partial class Example1Window : UserControl
    {
        public Example1Window()
        {
            InitializeComponent();
        }
    }
}
