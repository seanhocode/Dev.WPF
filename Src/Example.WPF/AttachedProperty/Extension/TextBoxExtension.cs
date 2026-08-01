using System.Windows;
using System.Windows.Controls;

// 未放入 .Core 是因為附加屬性是 WPF 的一部分，故放在 Example.AttachedProperty 目錄下
namespace Example.WPF.AttachedProperty.Extension
{
    /*
     * 因附加屬性是要附加到其他控件上的，所以要額外定義一個類別來裝載附加屬性
     * 將類別標記為 static 可以：
     *      防止誤用： 確保其他人不會不小心 new TextBoxExtension() 實例化它
     *      語意更明確： 明確告訴編譯器和閱讀程式碼的人，這是一個純工具/擴充類別
     */
    /// <summary>
    /// TextBox 的附加屬性擴充類別範例，提供附加屬性 IsEnableWatcher、HasText、ChangeCount
    /// </summary>
    public static class TextBoxExtension
    {
        /// <summary>
        /// 附加屬性 IsEnableWatcher，當設定為 true 時，會開始監聽 TextBox 的 TextChanged 事件，並更新 HasText 與 ChangeCount 屬性
        /// </summary>
        /// <remarks>
        /// <para>為附加屬性增加開關，避免找不到時機點去掛載 TextChanged 事件</para>
        /// <para>DependencyProperty 屬性命名規範: 屬性名稱 + Property</para>
        /// <para>附加屬性是由 <see cref="DependencyProperty"/> 這個類別中的靜態方法 <see cref="DependencyProperty.RegisterAttached"/> 去註冊的</para>
        /// </remarks>
        public static readonly DependencyProperty IsEnableWatcherProperty =
            DependencyProperty.RegisterAttached(
                "IsEnableWatcher",                                      //附加屬性名稱
                typeof(bool),                                           //附加屬性類型
                typeof(TextBoxExtension),                               //附加屬性屬於哪個類別
                new PropertyMetadata(false, OnIsEnableWatcherChanged)); //附加屬性的其它設定

        /// <summary>
        /// 透過靜態方法 GetCustom 來取得附加屬性的值
        /// </summary>
        /// <param name="obj">要取得附加屬性的目標物件</param>
        /// <remarks>
        /// <para>GetCustom 上面設定 <see cref="AttachedPropertyBrowsableForTypeAttribute"/> 可以用來指定甚麼類型的控件才可以使用這個附加屬性</para>
        /// <para>GetCustom 命名規範: Get + 屬性名稱</para>
        /// </remarks>
        /// <returns>附加屬性的值</returns>
        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetIsEnableWatcher(DependencyObject obj) => (bool)obj.GetValue(IsEnableWatcherProperty);
        /// <summary>
        /// 透過靜態方法 SetCustom 來設定附加屬性的值
        /// </summary>
        /// <param name="obj">要設定附加屬性的目標物件</param>
        /// <param name="value">要設定的附加屬性值</param>
        /// <remarks>
        /// <para>SetCustom 命名規範: Set + 屬性名稱</para>
        /// </remarks>
        public static void SetIsEnableWatcher(DependencyObject obj, bool value) => obj.SetValue(IsEnableWatcherProperty, value);


        public static readonly DependencyProperty HasTextProperty =
            DependencyProperty.RegisterAttached(
                "HasText",
                typeof(bool),
                typeof(TextBoxExtension),
                new PropertyMetadata(default(bool)));

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetHasText(DependencyObject obj) => (bool)obj.GetValue(HasTextProperty);
        public static void SetHasText(DependencyObject obj, bool value) => obj.SetValue(HasTextProperty, value);


        public static readonly DependencyProperty ChangeCountProperty =
            DependencyProperty.RegisterAttached(
                "ChangeCount",
                typeof(int),
                typeof(TextBoxExtension),
                new PropertyMetadata(default(int)));
        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static int GetChangeCount(DependencyObject obj) => (int)obj.GetValue(ChangeCountProperty);
        public static void SetChangeCount(DependencyObject obj, int value) => obj.SetValue(ChangeCountProperty, value);

        /// <summary>
        /// 當 IsEnableWatcher 附加屬性的值發生改變時所觸發的回呼方法，
        /// 負責根據傳入的新值 (True/False)，來動態註冊或解除綁定 TextBox 的 TextChanged 事件
        /// </summary>
        /// <param name="d">觸發此屬性變更的相依性物件 (預期為 TextBox 控制項)</param>
        /// <param name="e">包含屬性變更資訊的事件資料，可從中取得舊值與新值 (NewValue)</param>
        private static void OnIsEnableWatcherChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                if ((bool)e.NewValue) { textBox.TextChanged += TextChangedExtension; }
                else { textBox.TextChanged -= TextChangedExtension; }
            }
        }

        /// <summary>
        /// TextChanged 的擴充事件處理方法，當附加屬性 IsEnableWatcher 設定為 true 時，TextBox 的 TextChanged 事件會觸發此方法
        /// </summary>
        /// <param name="sender">觸發事件的來源物件</param>
        /// <param name="e">包含文字變更資訊的事件資料</param>
        private static void TextChangedExtension(object sender, TextChangedEventArgs e)
        {
            //此 textBox 為觸發 TextChanged 事件的 TextBox 控件
            if (sender is TextBox textBox)
            {
                SetHasText(textBox, !string.IsNullOrEmpty(textBox.Text));
                SetChangeCount(textBox, GetChangeCount(textBox) + 1);
            }
        }
    }
}