using System.ComponentModel;

namespace Example.WPF.Core.DataBinding.DataContexts
{
    // 要實現資料更新反饋至 UI 的功能，必須繼承 INotifyPropertyChanged 介面並實作 PropertyChanged 事件
    public class INotifyPropertyChangedDataContext : INotifyPropertyChanged
    {
        private double _INotifyPropertyChangedDataContextValue;
        public double INotifyPropertyChangedDataContextValue
        {
            get
            {
                return _INotifyPropertyChangedDataContextValue;
            }
            set
            {
                if (_INotifyPropertyChangedDataContextValue != value)
                {
                    _INotifyPropertyChangedDataContextValue = value;
                    OnPropertyChanged(nameof(INotifyPropertyChangedDataContextValue));
                }
            }
        }

        /// <summary>
        /// PropertyChanged 事件
        /// </summary>
        /// <remarks>此事件為 INotifyPropertyChanged 提供的事件，用於通知 UI 屬性值已變更</remarks>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 觸發 PropertyChanged 事件的方法
        /// </summary>
        /// <param name="propertyName">屬性名稱</param>
        /// <remarks>當屬性值變更時，會觸發此事件以通知 UI 更新</remarks>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
