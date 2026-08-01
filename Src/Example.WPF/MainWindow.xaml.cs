using Example.WPF.Infrastructure.Example;
using Example.WPF.Infrastructure.Example.Attributes;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Example.WPF;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        LoadExamples();
    }

    /// <summary>
    /// 掃描當前 Assembly 中所有帶有 ExampleAttribute 的 UserControl 類別，並將其組織成樹狀結構以顯示在 TreeView 中
    /// </summary>
    private void LoadExamples()
    {
        ObservableCollection<ExampleNode> rootNodes = new ObservableCollection<ExampleNode>();

        // 掃描當前 Assembly 中所有繼承自 UserControl 且帶有 ExampleAttribute 的類別
        IEnumerable<Type> types = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.IsSubclassOf(typeof(UserControl)) &&
                        t.GetCustomAttribute<ExampleAttribute>() != null);

        foreach (Type type in types)
        {
            ExampleAttribute? attr = type.GetCustomAttribute<ExampleAttribute>();

            // 以 '/' 作為階層分隔符號，例如 "Layout/Canvas"
            if (attr != null)
            {
                string[] categories = attr.Category.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                ObservableCollection<ExampleNode> currentLevel = rootNodes;

                // 建構或尋找對應的分類目錄節點
                foreach (String cat in categories)
                {
                    ExampleNode? node = currentLevel.FirstOrDefault(n => n.Title == cat && !n.IsExample);
                    if (node == null)
                    {
                        node = new ExampleNode { Title = cat };
                        currentLevel.Add(node);
                    }
                    currentLevel = node.SubNodes;
                }

                // 在最底層目錄加入實際的範例節點
                currentLevel.Add(new ExampleNode
                {
                    Title = attr.Title,
                    TargetType = type,
                    DefinitionType = attr.DefinitionType
                });
            }
        }

        ExampleTreeView.ItemsSource = rootNodes;
    }

    /// <summary>
    /// 當 TreeView 的選取項目改變時，動態載入對應的 UserControl 並顯示在 MainContent 中。
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ExampleTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        if (e.NewValue is ExampleNode selectedNode && selectedNode.IsExample)
        {
            try
            {
                // 實例化上半部的 UI 範例
                UserControl? exampleControl = (UserControl?)Activator.CreateInstance(selectedNode.TargetType);
                ExampleContent.Content = exampleControl;

                // 實例化下半部的 定義 (Definition)
                if (selectedNode.DefinitionType != null)
                {
                    var definitionInstance = Activator.CreateInstance(selectedNode.DefinitionType);
                    DefinitionContent.Content = definitionInstance;
                }
                else
                {
                    // 若未指定 Definition，給予預設提示或清空
                    DefinitionContent.Content = "此範例未提供相關定義。";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入範例失敗: {ex.Message}");
            }
        }
    }
}