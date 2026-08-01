namespace Example.WPF.Core.Model.Definition.DataBinding.INotifyPropertyChanged
{
    public class Example1Definition : INotifyPropertyChangedDefinition
    {
        public static string Title = "Example1Window";

        public Example1Definition()
        {
            ExampleDescription = @"
此範例示範未實作通知機制時，
資料變更無法即時反映到 UI 的情境
";
        }
    }
}



