using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Example.Resource
{
    public partial class Example1Window : Window
    {
        public Example1Window()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 啟動視窗時載入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await StartStyleColorLoopAsync();
        }

        /// <summary>
        /// 循環變更 BigLabelStyleDynamic 的 Foreground 顏色
        /// </summary>
        /// <returns></returns>
        private async Task StartStyleColorLoopAsync()
        {
            byte r = 255;
            byte g = 0;
            byte b = 0;

            /* XAML 中定義 BigLabelStyleDynamic 的基底為 App.xaml 的 BigLabelStyleBase，
             * 故用程式更新的 BigLabelStyleDynamic 也要繼承 BigLabelStyleBase 的屬性
             */
            System.Windows.Style? baseStyle = Application.Current.Resources["BigLabelStyleBase"] as System.Windows.Style;

            while (true)
            {
                if (r == 255 && g < 255 && b == 0) g++;
                else if (g == 255 && r > 0 && b == 0) r--;
                else if (g == 255 && b < 255 && r == 0) b++;
                else if (b == 255 && g > 0 && r == 0) g--;
                else if (b == 255 && r < 255 && g == 0) r++;
                else if (r == 255 && b > 0 && g == 0) b--;

                // 1. 建立一個全新的 Style，目標類型是 Label
                System.Windows.Style newDynamicStyle = new System.Windows.Style(typeof(Label));

                // 2. 如果有抓到基底樣式，就加上 BasedOn 屬性
                if (baseStyle != null) { newDynamicStyle.BasedOn = baseStyle; }

                // 3. 為這個新 Style 加上 Foreground 變色的 Setter
                newDynamicStyle.Setters.Add(
                    new Setter(Label.ForegroundProperty, new SolidColorBrush(Color.FromRgb(r, g, b)))
                );

                /* 4. 將 <Grid.Resources> 裡面的 Style 替換掉
                 * 用 DynamicResource 引用 BigLabelStyleDynamic 的控件會偵測到 Resources 換了，自動更新 UI。
                 * 用 StaticResource 引用 BigLabelStyleDynamic 的控件並不會更新
                 */
                MainGrid.Resources["BigLabelStyleDynamic"] = newDynamicStyle;

                // 暫停 20 毫秒，讓 UI 有時間重新渲染
                await Task.Delay(20);
            }
        }
    }
}
