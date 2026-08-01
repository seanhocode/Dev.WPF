namespace Example.WPF.Core.Model.Definition.DataBinding.DependencyProperties
{
    public class FirstUserControlDefinition
    {
        public static string Description = @"
此UserControl實作一個 DependencyProperty，
讓外部可以將值綁定至 FirstUserControlValue 屬性，
且 FirstUserControlValue 已綁定至 UserControl 內部的 TextBlock，
故外部綁定值至 FirstUserControlValue 後，TextBlock 會顯示綁定的值。
";
    }
}
