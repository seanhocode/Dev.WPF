namespace Example.WPF.Core.Model.Definition.Resource
{
    public class ResourceDefinition : MainWindowDefinition
    {
        public ResourceDefinition()
        {
            ExampleDefinition = @"
Resource 是 WPF 的可重用資源機制，可集中存放、管理樣式、筆刷、字串或其他物件，並透過 Key 引用，
WPF 裡面所有控制項都有 Resources 屬性，透過它，
可以將顏色、樣式 (Styles)、控制項範本 (Templates)、動畫或資料物件定義在一個集中的地方，
並在應用程式的不同區域多次引用它們
";
        }
    }
}
