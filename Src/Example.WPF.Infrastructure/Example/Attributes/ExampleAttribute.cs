namespace Example.WPF.Infrastructure.Example.Attributes
{
    /// <summary>
    /// MainWindow 的 DataTreeView 節點資訊自訂屬性
    /// </summary>
    // 限定此自訂屬性僅能套用於「類別 (Class)」，且衍生子類別不會繼承此屬性。
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class ExampleAttribute : Attribute
    {
        /// <summary>
        /// DataTreeView 節點分類
        /// </summary>
        public string Category { get; }

        /// <summary>
        /// DataTreeView 節點標題
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// 範例的定義
        /// </summary>
        public Type? DefinitionType { get; set; }

        public ExampleAttribute(string category, string title)
        {
            Category = category;
            Title = title;
        }
    }
}
