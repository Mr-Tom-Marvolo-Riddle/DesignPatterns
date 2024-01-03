using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFApp.ViewModels
{
    public class AViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<AModel> MyList { get; set; }

        public AViewModel()
        {
            MyList = new ObservableCollection<AModel>();
        }
    }
}