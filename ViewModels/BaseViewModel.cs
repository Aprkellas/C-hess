using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C___hess.Services;
using System.Windows.Navigation;

namespace C___hess.ViewModels
{
    class BaseViewModel
    {
        protected readonly NavService _navigationService;

        public BaseViewModel(NavService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
