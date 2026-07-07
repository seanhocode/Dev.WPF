namespace Example.WPF.Core.DataBinding.DataContexts
{
    /// <summary>
    /// 資料綁定範例，此類別扮演資料環境 (DataContext) 的角色
    /// </summary>
    /// <remarks>
    /// C# 程式碼中綁定的類別被稱作資料環境 (DataContext)，也可以當作是資料綁定的來源 (Binding Source)
    /// </remarks>
    public class FirstDataContext
    {
        private double _FirstDataContextValue;

        /// <summary>
        /// 提供給前端 XAML 綁定的屬性
        /// </summary>
        /// <remarks>名稱須與 XAML 中的 {Binding FirstDataContextValue} 一致</remarks>
        public double FirstDataContextValue
        {
            get
            {
                /*
                 * 取值：
                 *      當 UI 需要顯示數值時 (例如畫面剛載入打開時)，
                 *      綁定機制會自動觸發這裡的 Get，來取得初始資料並顯示在畫面上。
                 */
                return _FirstDataContextValue;
            }
            set
            {
                /*
                 * 存值：
                 *      當 Binding Target (前端的 Slider) 的值被拖拉改變時，
                 *      新的值會自動傳回這個 Binding Source。
                 * 
                 * P.S. 在這裡下中斷點可觀察 Example1 中的 Slider 的值改變時，Binding Source 的值也會跟著改變。
                 */
                _FirstDataContextValue = value;
            }
        }

        private string? _FirstDataContextTextValue;
        public string? FirstDataContextTextValue
        {
            get { return _FirstDataContextTextValue; }
            set
            {
                //在這裡下中斷點可觀察 Example2 中的 TextBox 的值改變且按下 Enter 時，Binding Source 的值也會跟著改變。
                _FirstDataContextTextValue = value;
            }
        }
    }
}
