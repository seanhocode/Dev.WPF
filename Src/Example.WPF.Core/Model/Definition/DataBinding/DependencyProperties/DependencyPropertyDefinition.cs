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
允許屬性值的自動通知、數據綁定、樣式和動畫等功能
";
        }
    }
}
