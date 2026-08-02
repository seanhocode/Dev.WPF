namespace Example.WPF.Core.Model.Definition.DataBinding.DependencyProperties
{
    public class Example1Definition : DependencyPropertyDefinition
    {
        public Example1Definition()
        {
            ExampleDescription = @"
此案例示範如何透過註冊相依屬性 (DependencyProperty) 使 UserControl 的屬性能夠支援資料綁定，
此案例會示範將 FirstDataContext 中的 FirstDataContextValue 綁定到 FirstUserControl 中的相依屬性 FirstUserControlValue。
P.S. 已於 Example1Content 的建構子中定義 FirstDataContextValue = 3.14159";
        }
    }
}
