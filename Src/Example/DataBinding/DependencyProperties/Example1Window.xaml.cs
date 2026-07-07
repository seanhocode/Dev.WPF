using System.Windows;

namespace Example.WPF.DataBinding.DependencyProperties
{
    public partial class Example1Window : Window
    {
        public Example1Window()
        {
            /*
             * 使用 ErrorUserControl 並綁定 ErrorUserControlValue 於此處會出現以下錯誤:
             *      System.Windows.Markup.XamlParseException: '無法在類型為 'ErrorUserControl' 的 'ErrorUserControlValue' 屬性上設定 'Binding'。只可在 DependencyObject 的 DependencyProperty 上設定 'Binding'。'
             * 原因是資料綁定不能綁定到普通的屬性，只能綁定到相依物件 (Dependency Object) 中的相依屬性 (Dependency Property)，
             * DataContexts 中卻能正確綁定資料原因是 WPF 內建的控件全部都繼承了 DependencyObject，並且所有屬性都已經實作成 DependencyProperty
             */
            InitializeComponent();
        }
    }
}
