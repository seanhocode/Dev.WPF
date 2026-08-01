namespace Example.WPF.Core.Model.Definition.DataBinding.INotifyPropertyChanged
{
    public class Example2Definition : INotifyPropertyChangedDefinition
    {
        public static string Title = "Example2Window";

        public Example2Definition()
        {
            ExampleDescription = @"
此範例示範正確使用 INotifyPropertyChanged，
讓資料更新時 UI 可以同步更新
";
        }
    }
}



