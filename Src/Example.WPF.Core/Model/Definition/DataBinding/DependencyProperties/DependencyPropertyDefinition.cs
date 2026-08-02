namespace Example.WPF.Core.Model.Definition.DataBinding.DependencyProperties
{
    public class DependencyPropertyDefinition : MainWindowDefinition
    {
        public DependencyPropertyDefinition() 
        {
            ExampleDefinition = @"
DependencyProperty 是 WPF 的核心概念之一，提供了一種特殊的屬性系統，
相依屬性(Dependency Property)是 WPF 的核心概念之一，
它的值不僅僅是單純存下來，而是可以自動跟隨其他資料改變(綁定)、被樣式套用(Style)或被動畫控制(Animation)，
允許屬性值的自動通知、數據綁定、樣式和動畫等功能，
簡單來說，相依屬性是在定義控制項時就註冊好的屬性，且只有註冊過的屬性才能將 Binding 回傳的內容作為輸入源，
任何想要接收並隨時聽從 Binding 資料變化的屬性，都必須是事先註冊好的 DependencyProperty
";
        }
    }
}
