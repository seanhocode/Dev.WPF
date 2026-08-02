using System.Windows.Controls;

namespace Example.WPF.DataBinding.DependencyProperties.UserControls
{
    /// <summary>
    /// 一個預設且沒有經過處理的 UserControl 範例
    /// </summary>
    /// <remarks>未設定 DependencyProperty，因此無法進行資料繫結</remarks>
    public partial class ErrorUserControl : UserControl
    {
        public ErrorUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 一個預設沒有任何處理的屬性
        /// </summary>
        public double DefaultAttributelValue { get; set; }
    }
}
