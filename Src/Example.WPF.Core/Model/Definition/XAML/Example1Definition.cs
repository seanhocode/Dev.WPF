namespace Example.WPF.Core.Model.Definition.XAML
{
    public class Example1Definition : XAMLDefinition
    {
        public static string Remark = "XAML 中能做到的事情 C# 一定都能做到，\r\n然而 C# 能做到的事情 XAML 卻不一定能做到";
        public static string XAMLShouldDo = "應使用 XAML：\r\n    1. 定義控制項\r\n    2. 定義動畫\r\n    3. 定義風格與樣版\r\n    4. 定義資源\r\n    5. 定義資料綁定";
        public static string CSharpShouldDo = "應使用 C#：\r\n    1. 定義邏輯\r\n    2. 事件處理\r\n    3. 例外處理\r\n    4. 資料儲存\r\n    5. 任何非使用者界面相關的工作";

        public Example1Definition()
        {
            ExampleDescription = @"
此範例解釋 XAML 中語法的定義，參考註解
";
        }
    }
}