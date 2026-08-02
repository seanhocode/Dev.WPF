namespace Example.WPF.Core.Model.Definition.AttachedProperty
{
    public class Example1Definition : AttachedPropertyDefinition
    {
        public static string Title = "Example1Window";

        public Example1Definition()
        {
            ExampleDescription = @"
此範例示範透過 Attached Property 擴充 TextBox 控制項的屬性，
並且 Label 透過 Binding 綁定 TextBox 的附加屬性值，
達到 Label 顯示 TextBox 的附加屬性值的效果
";
        }
    }
}



