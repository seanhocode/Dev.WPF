namespace Example.WPF.Core.Model.Definition.DataBinding.DataContexts
{
    public class Example2Definition : DataContextDefinition
    {
        public Example2Definition()
        {
            ExampleDescription = @"
此範例示範於 .cs 中透過 DataContext 進行基本資料綁定，
子控制項可沿視覺樹繼承父層的 DataContext 來解析 Binding 路徑，
可在 FirstDataContext.FirstDataContextTextValue 的 Setter 中下中斷點觀察按下 Enter 後 FirstDataContextTextValue 的變化
";
        }
    }
}



