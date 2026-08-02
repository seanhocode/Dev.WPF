using Example.WPF.Infrastructure.DataBinding.DataContexts;
using Example.WPF.Infrastructure.Example.Attributes;
using System.Windows.Controls;

namespace Example.WPF.DataBinding.Sources
{
    [Example("DataBinding/Source", "Source 範例", DefinitionType = typeof(Example.WPF.Core.Model.Definition.DataBinding.Sources.Example1Definition))]
    public partial class Example1Content : UserControl
    {
        public Example1Content()
        {
            FirstDataContext firstDataContext = new FirstDataContext();
            firstDataContext.FirstDataContextTextValue = "Hello World";
            this.Resources.Add("FirstDataContext", firstDataContext);

            InitializeComponent();
        }
    }
}
