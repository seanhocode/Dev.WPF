namespace Example.WPF.Core.Model.Definition.MarkupExtensions
{
    public class MarkupExtensionsDefinition : MainWindowDefinition
    {
        public MarkupExtensionsDefinition()
        {
            ExampleDefinition = @"
Markup Extension 是 XAML 的擴充機制，
可在屬性設定時動態提供值或封裝重複設定邏輯，
所有的 Markup Extension 都是繼承並實作 MarkupExtension 類別，透過 ProvideValue() 來提供值給 XAML，
簡單來說，在 XAML 中大括號 {} 裡面的內容就是 Markup Extension
";
        }
    }
}
