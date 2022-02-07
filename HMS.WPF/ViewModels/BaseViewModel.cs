using System.ComponentModel;

namespace HMS.WPF.ViewModels
{
    //A Base View Model to fire Property Changed Events
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
