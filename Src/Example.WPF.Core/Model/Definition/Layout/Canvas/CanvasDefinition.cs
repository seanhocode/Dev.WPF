namespace Example.WPF.Core.Model.Definition.Layout.Canvas
{
    public class CanvasDefinition : MainWindowDefinition
    {
        public CanvasDefinition()
        {
            ExampleDefinition = @"
Canvas 是以絕對座標定位子控制項的版面容器，
透過 Left/Top/Right/Bottom 等附加屬性決定位置
";
        }
    }
}
