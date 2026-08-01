namespace Example.WPF.Core.Model.Definition.Layout.DockPanel
{
    public class DockPanelDefinition : MainWindowDefinition
    {
        public DockPanelDefinition()
        {
            ExampleDefinition = @"
DockPanel 是依序將子控制項停靠於上、下、左、右的版面容器，
通常最後一個控制項可填滿剩餘空間
";
        }
    }
}
