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
    /// 載入範例資料
    /// </summary>
    /// <remarks>掃描當前 Assembly 中所有帶有 ExampleAttribute 的 UserControl 類別，並將其資訊整理成 ExampleNode 結構，並綁定到 TreeView 上</remarks>
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
                // 從根節點開始，逐層建立或尋找對應的分類目錄節點，因為此處是傳參考，所以更新 currentLevel = 更新 rootNodes
                ObservableCollection<ExampleNode> currentLevel = rootNodes;

                // 建構或尋找對應的分類目錄節點
                foreach (String cat in categories)
                {
                    // 尋找當前層級中是否已存在該分類節點
                    ExampleNode? node = currentLevel.FirstOrDefault(n => n.Title == cat && !n.IsExample);
                    // 若不存在，則建立新的分類節點
                    if (node == null)
                    {
                        node = new ExampleNode { Title = cat };
                        currentLevel.Add(node);
                    }
                    // 進入下一層級
                    currentLevel = node.SubNodes;
                }

                // 在最底層目錄加入實際的範例節點
                currentLevel.Add(new ExampleNode
                {
                    Title = attr.Title,
                    ExampleContent = type,
                    DefinitionContent = attr.DefinitionType
                });
            }
        }

        ExampleTreeView.ItemsSource = rootNodes;
    }

    /// <summary>
    /// ExampleTreeView 的選取項目改變事件處理器
    /// </summary>
    /// <remarks>當 TreeView 的選取項目改變時，根據選取的 ExampleNode 動態載入對應的範例與定義 Content</remarks>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ExampleTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        if (e.NewValue is ExampleNode selectedNode)
        {
            if (selectedNode.IsExample)
            {
                try
                {
                    UserControl? exampleControl;
                    // 實例化上半部的 UI 範例
                    if (selectedNode.ExampleContent != null)
                    {
                        exampleControl = (UserControl?)Activator.CreateInstance(selectedNode.ExampleContent);
                        ExampleContent.Content = exampleControl;
                    }

                    // 實例化下半部的 定義 (Definition)
                    if (selectedNode.DefinitionContent != null)
                    {
                        Object? definitionInstance = Activator.CreateInstance(selectedNode.DefinitionContent);
                        DefinitionContent.Content = definitionInstance;
                    }
                    else
                    {
                        // 若未指定 Definition，給予預設提示或清空
                        DefinitionContent.Content = "此範例未提供相關定義";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"載入範例失敗: {ex.Message}");
                }
            }
            else
            {
                // 若選取的節點不是範例，清空內容
                ExampleContent.Content = null;
                Label label = new Label();
                label.FontSize = 36;
                label.Content = $"{selectedNode.Title} 範例";
                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.VerticalAlignment = VerticalAlignment.Center;
                DefinitionContent.Content = label;
            }
        }
        else
        {
            // 若選取的不是節點，清空內容
            ExampleContent.Content = null;
            DefinitionContent.Content = "請選擇範例";
        }
    }
}