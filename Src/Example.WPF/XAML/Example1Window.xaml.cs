using System.Windows.Controls;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.XAML
{
    [Example("XAML", "XAML 基本範例", DefinitionType = typeof(Core.Model.Definition.XAML.Example1Definition))]
    public partial class Example1Window : UserControl
    {
        public Example1Window()
        {
            InitializeComponent();
        }
    }
}
