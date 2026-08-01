namespace Example.WPF.Infrastructure.Attributes
{
    // 限定此自訂屬性僅能套用於「類別 (Class)」，且衍生子類別不會繼承此屬性。
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class ExampleAttribute : Attribute
    {
        public string Category { get; }
        public string Title { get; }

        public ExampleAttribute(string category, string title)
        {
            Category = category;
            Title = title;
        }
    }
}
