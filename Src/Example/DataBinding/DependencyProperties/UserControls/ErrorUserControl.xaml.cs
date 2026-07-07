using System.Windows.Controls;

namespace Example.WPF.DataBinding.DependencyProperties.UserControls
{
    /// <summary>
    /// 相依物件 (DependencyObject) 錯誤範例
    /// </summary>
    /// <remarks>未設定 DependencyProperty，因此無法進行資料繫結</remarks>
    public partial class ErrorUserControl : UserControl
    {
        public ErrorUserControl()
        {
            InitializeComponent();
        }

        public double ErrorUserControlValue { get; set; }
    }
}
