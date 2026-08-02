using System.Collections.ObjectModel;

namespace Example.WPF.Infrastructure.Example
{
    /// <summary>
    /// MainWindow 中 ExampleTreeView 的節點資訊
    /// </summary>
    public class ExampleNode
    {
        /// <summary>
        /// TreeView 節點標題名稱
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// 節點對應的範例內容 Type
        /// </summary>
        public Type? ExampleContent { get; set; }

        /// <summary>
        /// 節點對應的定義內容 Type
        /// </summary>
        public Type? DefinitionContent { get; set; }

        /// <summary>
        /// TreeView 此節點的子節點
        /// </summary>
        public ObservableCollection<ExampleNode> SubNodes { get; set; } = new ObservableCollection<ExampleNode>();

        /// <summary>
        /// 判斷此節點是否為範例節點
        /// </summary>
        public bool IsExample => ExampleContent != null;
    }
}
