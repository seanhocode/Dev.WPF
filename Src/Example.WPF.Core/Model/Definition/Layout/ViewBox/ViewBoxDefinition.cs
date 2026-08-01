namespace Example.WPF.Core.Model.Definition.Layout.ViewBox
{
    public class ViewBoxDefinition : MainWindowDefinition
    {
        public ViewBoxDefinition()
        {
            ExampleDefinition = @"
ViewBox 會依可用空間等比或非等比縮放其子內容，
常用於維持內容在不同尺寸下的可視性
";
        }
    }
}
