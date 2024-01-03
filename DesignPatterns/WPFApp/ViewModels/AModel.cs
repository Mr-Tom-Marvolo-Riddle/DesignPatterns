using System.ComponentModel;

namespace WPFApp.ViewModels
{
    public class AModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _a;

        public string A
        {
            get { return _a; }
            set
            {
                _a = value;
                RaisePropertyChanged(nameof(A));
            }
        }
    }
}