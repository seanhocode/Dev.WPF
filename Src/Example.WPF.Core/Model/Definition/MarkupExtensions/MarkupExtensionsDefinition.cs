namespace Example.WPF.Core.Model.Definition.MarkupExtensions
{
    public class MarkupExtensionsDefinition : MainWindowDefinition
    {
        public MarkupExtensionsDefinition()
        {
            ExampleDefinition = @"
Markup Extension 是 XAML 的擴充機制，
可在屬性設定時動態提供值或封裝重複設定邏輯
";
        }
    }
}
