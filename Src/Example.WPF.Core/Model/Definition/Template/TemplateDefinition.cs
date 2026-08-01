namespace Example.WPF.Core.Model.Definition.Template
{
    public class TemplateDefinition : MainWindowDefinition
    {
        public TemplateDefinition()
        {
            ExampleDefinition = @"
Template 用於定義控制項或資料的顯示方式，所有的控制項都是以預設的範本來顯示，
Template 覆寫控制項的範本就可以讓控制項按照自訂設計顯示，
常見包含 ControlTemplate 與 DataTemplate
";
        }
    }
}
