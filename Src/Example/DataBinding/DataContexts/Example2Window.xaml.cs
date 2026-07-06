using System.Windows;
using Example.WPF.Core.DataBinding.DataContexts;

namespace Example.WPF.DataBinding.DataContexts
{
    public partial class Example2Window : Window
    {
        public Example2Window()
        {
            InitializeComponent();

            FirstDataContext firstDataContext = new FirstDataContext();
            firstDataContext.FirstTextValue = "HelloWorld";

            // 於 C# 中定義 DataContext，並將其設置為 firstDataContext 實例
            this.DataContext = firstDataContext;
        }
    }
}
