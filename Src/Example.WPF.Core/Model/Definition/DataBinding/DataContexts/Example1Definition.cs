namespace Example.WPF.Core.Model.Definition.DataBinding.DataContexts
{
    public class Example1Definition : DataContextDefinition
    {
        public Example1Definition()
        {
            ExampleDescription = @"
此範例示範於 XAMP 中透過 DataContext 進行基本資料綁定，
子控制項可沿視覺樹繼承父層的 DataContext 來解析 Binding 路徑，
可在 FirstDataContext.FirstDataContextValue 的 Setter 中下中斷點觀察調整 Slider 後 FirstDataContextValue 的變化
";
        }
    }
}



