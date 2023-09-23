using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using C___hess.Services;
using YourNamespace.Commands;

namespace C___hess.ViewModels
{
    class MainMenuViewModel
    {
        public MainMenuViewModel() 
        {
            play = new RelayCommand(Play);
            instructions = new RelayCommand(ShowInstructions);
            quit = new RelayCommand(QuitGame);
        }

        private void Play()
        {

        }
        private void ShowInstructions()
        {

        }

        private void QuitGame()
        {

        }

        public ICommand play { get; }
        public ICommand instructions { get; }
        public ICommand quit { get; }
    }
}
