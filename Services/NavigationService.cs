using C___hess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C___hess.Services
{
    public class NavService : INotifyPropertyChanged
    {
        private object currentDataContext;

        public Object CurrentDataContext
        {
            get { return currentDataContext; }
            set
            {
                if (currentDataContext != value)
                {
                    currentDataContext = value;
                    OnPropertyChanged(nameof(CurrentDataContext));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NavigateToViewModel(object viewModel)
        {
            CurrentDataContext = viewModel;
        }
    }
}
