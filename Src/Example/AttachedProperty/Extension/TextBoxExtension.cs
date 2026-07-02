using System.Windows;
using System.Windows.Controls;

namespace Example.AttachedProperty.Extension
{
    /*
     * 因附加屬性是要附加到其他控件上的，所以要額外定義一個類別來裝載附加屬性
     * 將類別標記為 static 可以：
     *      防止誤用： 確保其他人不會不小心 new TextBoxExtension() 實例化它
     *      語意更明確： 明確告訴編譯器和閱讀程式碼的人，這是一個純工具/擴充類別
     */
    public static class TextBoxExtension
    {
        /*
         * 為附加屬性增加開關，避免找不到時機點去掛載 TextChanged 事件，
         * DependencyProperty 屬性命名規範: 屬性名稱 + Property
         */
        public static readonly DependencyProperty IsEnableWatcherProperty =
            //附加屬性透過 DependencyProperty.RegisterAttached 方法來註冊
            DependencyProperty.RegisterAttached(
                "IsEnableWatcher",                                      //附加屬性名稱
                typeof(bool),                                           //附加屬性類型
                typeof(TextBoxExtension),                               //附加屬性屬於哪個類別
                new PropertyMetadata(false, OnIsEnableWatcherChanged)); //附加屬性的其它設定

        /*
         *  附加屬性取值或賦值:
         *      透過靜態方法Gett[AttachedProperty], Sett[AttachedProperty]來操作，
         *      命名規範: Get + 屬性名稱 / Set + 數性名稱，
         *      Get[AttachedProperty] 上面設定 AttachedPropertyBrowsableForType 可以用來指定甚麼類型的控件才可以使用這個附加屬性
        */
        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetIsEnableWatcher(DependencyObject obj) => (bool)obj.GetValue(IsEnableWatcherProperty);
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