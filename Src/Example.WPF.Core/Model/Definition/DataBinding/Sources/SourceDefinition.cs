
namespace Example.WPF.Core.Model.Definition.DataBinding.Sources
{
    public class SourceDefinition : MainWindowDefinition
    {
        public SourceDefinition() 
        {
            ExampleDefinition = @"
Source 屬性可以直接指定資料綁定的 DataContext，要指定的 DataContext 可以利用 Resource 的方式輸入，
若要綁定到其他控件的屬性，則可以設定該控件的 Name 屬性，並將該 Name 屬性的值輸入 ElementName，
若要綁定到其他控件，但無法確定該控件的 Name，只能透過控件之間的相對層級來尋找控件時，就可以使用 RelativeSource 來指定控件
";
        }
    }
}
