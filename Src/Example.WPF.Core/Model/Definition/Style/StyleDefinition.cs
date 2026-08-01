namespace Example.WPF.Core.Model.Definition.Style
{
    public class StyleDefinition : MainWindowDefinition
    {
        public StyleDefinition()
        {
            ExampleDefinition = @"
Style 可自訂設定各控制項的樣式，
用於集中定義控制項外觀與行為設定，
透過 Setter、Trigger 等機制重用 UI 規則
";
        }
    }
}
