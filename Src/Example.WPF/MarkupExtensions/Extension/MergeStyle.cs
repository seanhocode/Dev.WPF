using System.Windows;
using System.Windows.Markup;

//未放入 .Core 是因為 MarkupExtension 是 WPF 的一部分，故放在 Example.MarkupExtensions 目錄下
namespace Example.WPF.MarkupExtensions.Extension
{
    /*
     * MarkupExtensionReturnType: 
     *      指定 MarkupExtension 的返回值類型，
     *      這樣在 XAML 中使用時，編譯器可以更好地推斷類型，
     *      並提供更好的 IntelliSense 支援。
     */
    [MarkupExtensionReturnType(typeof(System.Windows.Style))]
    public class MergeStyle : MarkupExtension
    {
        public System.Windows.Style? BasedOn { get; set; }
        public System.Windows.Style? MergeWith { get; set; }

        /*
         * override ProvideValue: 
         *      當 XAML 解析器遇到這個 MarkupExtension 時，
         *      會呼叫 ProvideValue 方法來獲取實際的值，override ProvideValue 來自定義返回的值。
         */
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (BasedOn == null || MergeWith == null)
                return BasedOn ?? MergeWith;

            /*
             * Style 一旦被建立並套用 (例如放在 Resources 中作為 StaticResource)，它就會被密封 (Sealed) 以提升效能，
             * 一旦被密封，該樣式的 Setters、Triggers 等集合就會變成唯讀狀態，無法再被修改，
             * 故需新建一個 Style 實體，避免直接修改已密封的 Style 實體造成 當 ['SetterBaseCollection' 使用 (已密封) 之後，即無法修改] 例外。
             */
            System.Windows.Style newStyle = new System.Windows.Style
            {
                TargetType = BasedOn.TargetType,
                BasedOn = BasedOn
            };

            return DoMergeStyle(newStyle, MergeWith);
        }

        /// <summary>
        /// 遞迴合併兩個 Style 的 Setters 和 Triggers，並返回合併後的 Style
        /// </summary>
        /// <param name="basedOn">基本 Style</param>
        /// <param name="mergeWith">被合併的 Style</param>
        /// <returns>合併後的 Style</returns>
        private System.Windows.Style DoMergeStyle(System.Windows.Style basedOn, System.Windows.Style mergeWith)
        {
            if(basedOn.BasedOn != null)
                basedOn = DoMergeStyle(basedOn.BasedOn, basedOn);

            foreach(SetterBase setter in mergeWith.Setters)
                basedOn.Setters.Add(setter);

            foreach(TriggerBase trigger in mergeWith.Triggers)
                basedOn.Triggers.Add(trigger);

            return basedOn;
        }
    }
}
