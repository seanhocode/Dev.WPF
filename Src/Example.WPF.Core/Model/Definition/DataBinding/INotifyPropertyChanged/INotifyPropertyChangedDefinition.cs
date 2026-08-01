namespace Example.WPF.Core.Model.Definition.DataBinding.INotifyPropertyChanged
{
    public class INotifyPropertyChangedDefinition : MainWindowDefinition
    {
        public INotifyPropertyChangedDefinition()
        {
            ExampleDefinition = @"
INotifyPropertyChanged 是 .NET 通知機制介面，
資料物件在屬性值變更時觸發 PropertyChanged 事件，通知 UI 使其可即時更新
";
        }
    }
}
