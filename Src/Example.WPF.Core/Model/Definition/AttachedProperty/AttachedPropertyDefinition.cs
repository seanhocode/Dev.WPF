namespace Example.WPF.Core.Model.Definition.AttachedProperty
{
    public class AttachedPropertyDefinition : MainWindowDefinition
    {
        public AttachedPropertyDefinition()
        {
            ExampleDefinition = @"
Attached Property 是 WPF 提供的一種可附加屬性機制，
允許在不修改原控制項類別的情況下，為目標物件擴充額外屬性，
簡單來說，就是控制項除了原本的屬性外，讓使用者可以在 XAML 中為控制項附加自訂的屬性
";
        }
    }
}
