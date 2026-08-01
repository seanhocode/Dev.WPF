using System.Windows;
using System.Windows.Controls;

namespace Example.WPF.DataBinding.DependencyProperties.UserControls
{
    /// <summary>
    /// 相依物件 (DependencyObject) 範例
    /// </summary>
    /// <remarks>UserControl 本身已經繼承自 DependencyObject，因此可以直接使用 DependencyProperty</remarks>
    public partial class FirstUserControl : UserControl
    {
        public FirstUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 註冊相依屬性 (Dependency Property) 範例
        /// </summary>
        /// <remarks>
        /// <para>1. 相依屬性並不存在於 <see cref="FirstUserControl"/> 類裡面，而是由 <see cref="DependencyProperty"/> 這個類別中的靜態方法 <see cref="DependencyProperty.Register"/> 去註冊進 <see cref="DependencyProperty"/></para>
        /// <para>2. WPF 中所有的控件中的相依屬性全部都交由 <see cref="DependencyProperty"/> 統一管理</para>
        /// <para>3. Register 方法註冊完後，會回傳一個 <see cref="DependencyProperty"/> 類別的物件(<see cref="FirstUserControlValueProperty"/>)，相依屬性一旦註冊完後就不應該被修改，因此使用 readonly 來修飾</para>
        /// <para>4. 相依屬性命名規範: 屬性名稱 + "Property"</para>
        /// <para>5. 註冊完後才可於 XAML 中使用 Binding 將資料來源綁定至該相依屬性</para>
        /// </remarks>
        public static readonly DependencyProperty FirstUserControlValueProperty =
            DependencyProperty.Register(
                nameof(FirstUserControlValue),  // 相依屬性名稱
                typeof(double),                 // 相依屬性類型
                typeof(FirstUserControl),       // 相依屬性屬於哪個類別
                new PropertyMetadata());        // 相依屬性的其它設定

        /// <summary>
        /// 相依屬性包裝器 (Wrapper)
        /// </summary>
        /// <remarks>
        /// <para>建立一屬性用於存取相依屬性 (Dependency Property) 的值</para>
        /// </remarks>
        public double FirstUserControlValue
        {
            /*
             * 透過 GetValue 、 SetValue 方法取得相依屬性 (Dependency Property) 的值
             * 資料綁定同步相依屬性時，系統會直接呼叫 DependencyObject.GetValue 和 DependencyObject.SetValue 來操作屬性，
             * 並不會透過 FirstUserControlValue，因此不應該在 FirstUserControlValue 的 getter 中加入其他的指令
             */
            get => (double)GetValue(FirstUserControlValueProperty);
            set => SetValue(FirstUserControlValueProperty, value); 
        }
    }
}
