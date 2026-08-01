using System.Windows.Controls;
using Example.WPF.Core.Model.DataBinding.DataContexts;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.DataBinding.DataContexts
{
    [Example("DataBinding/DataContexts", "基本範例2", DefinitionType = typeof(Example.WPF.Core.Model.Definition.DataBinding.DataContexts.Example2Definition))]
    public partial class Example2Content : UserControl
    {
        public Example2Content()
        {
            InitializeComponent();

            FirstDataContext firstDataContext = new FirstDataContext();
            firstDataContext.FirstDataContextTextValue = "HelloWorld";

            // 於 C# 中定義 DataContext，並將其設置為 firstDataContext 實例
            this.DataContext = firstDataContext;
        }
    }
}
