using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace C___hess.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void NavigateTo(string viewModelName, object parameter = null)
        {
            RequestNavigation?.Invoke(this, new NavigationEventArgs(viewModelName, parameter));
        }

        public event EventHandler<NavigationEventArgs> RequestNavigation;
        public event PropertyChangedEventHandler PropertyChanged;

    }
    public class NavigationEventArgs : EventArgs
    {
        public NavigationEventArgs(string viewModelName, object parameter)
        {
            ViewModelName = viewModelName;
            Parameter = parameter;
        }

        public string ViewModelName { get; }
        public object Parameter { get; }
    }
}
