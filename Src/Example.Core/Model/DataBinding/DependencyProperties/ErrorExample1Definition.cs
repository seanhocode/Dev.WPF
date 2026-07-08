
namespace Example.WPF.Core.Model.DataBinding.DependencyProperties
{
    public class ErrorExample1Definition
    {
        public static string Title = "ErrorExample1Window";
        public static string Description = @"
使用 ErrorUserControl 並綁定 ErrorUserControlValue 會出現以下錯誤:
    System.Windows.Markup.XamlParseException: '無法在類型為 'ErrorUserControl' 的 'ErrorUserControlValue' 屬性上設定 'Binding'。
    只可在 DependencyObject 的 DependencyProperty 上設定 'Binding'。'
原因是資料綁定不能綁定到普通的屬性，只能綁定到相依物件 (Dependency Object) 中的相依屬性 (Dependency Property)，
範例 DataContexts 中能正確綁定原因是 WPF 內建的控件全部已繼承 DependencyObject，且所有屬性都已經實作成 DependencyProperty，
如要讓 ErrorUserControl 的 ErrorUserControlValue 正確綁定 FirstDataContextValue，請參考 DependencyProperties.Example2 範例";
    }
}