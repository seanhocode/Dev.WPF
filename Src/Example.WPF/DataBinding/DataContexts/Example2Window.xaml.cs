using System.Windows.Controls;
using Example.WPF.Core.Model.DataBinding.DataContexts;
using Example.WPF.Infrastructure.Example.Attributes;

namespace Example.WPF.DataBinding.DataContexts
{
    [Example("DataBinding/DataContexts", "基本範例2")]
    public partial class Example2Window : UserControl
    {
        public Example2Window()
        {
            InitializeComponent();

            FirstDataContext firstDataContext = new FirstDataContext();
            firstDataContext.FirstDataContextTextValue = "HelloWorld";

            // 於 C# 中定義 DataContext，並將其設置為 firstDataContext 實例
            this.DataContext = firstDataContext;
        }
    }
}
