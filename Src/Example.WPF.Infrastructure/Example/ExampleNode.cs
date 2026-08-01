using System.Collections.ObjectModel;

namespace Example.WPF.Infrastructure.Example
{
    public class ExampleNode
    {
        public required string Title { get; set; }

        // 若為分類節點，此屬性為 null；若為具體範例，則記錄該 UserControl 的 Type
        public Type? TargetType { get; set; }

        public Type? DefinitionType { get; set; }

        public ObservableCollection<ExampleNode> SubNodes { get; set; } = new ObservableCollection<ExampleNode>();

        public bool IsExample => TargetType != null;
    }
}
