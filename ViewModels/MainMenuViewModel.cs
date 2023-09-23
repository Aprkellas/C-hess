using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using C___hess.Services;
using C___hess.Views;

namespace C___hess.ViewModels
{
    class MainMenuViewModel 
    {
        public MainMenuViewModel() 
        {
        }

        public void Play()
        {
            (Application.Current.MainWindow as MainWindow)?.NavigateToView(new GameView());

        }
        public void ShowInstructions()
        {

        }

        public void QuitGame()
        {
            Application.Current.Shutdown();
        }

        public ICommand play { get; }
        public ICommand instructions { get; }
        public ICommand quit { get; }
        public ICommand NavigateToGameCommand { get; }
    }
}
