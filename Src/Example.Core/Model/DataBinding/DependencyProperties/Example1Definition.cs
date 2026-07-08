
namespace Example.WPF.Core.Model.DataBinding.DependencyProperties
{
    public class Example1Definition
    {
        public static string Title = "Example1Window";
        public static string Description = @"
此案例示範如何使用相依物件 (DependencyObject) 及註冊相依屬性 (DependencyProperty) 來讓屬性能夠支援資料綁定，
此案例會示範將 FirstDataContext 中的 FirstDataContextValue 綁定到 FirstUserControl 中的相依屬性 FirstUserControlValue。
P.S. 已於 Example1Window 的建構子中定義 FirstDataContextValue = 3.14159";
    }
}
