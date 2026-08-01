namespace Example.WPF.Core.Model.Definition.Style
{
    public class Example2Definition : StyleDefinition
    {
        public Example2Definition()
        {
            ExampleDescription = @"
此範例示範 Style 透過 x:Key 命名，
於控制項中透過 StaticResource 或 DynamicResource 來指定引用，
並透過 BasedOn 屬性來繼承其他 Style 的設定
";
        }
    }
}



