using C___hess.Services;
using C___hess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C___hess.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : UserControl
    {
        public MainMenuView()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Content.ToString())
                {
                    case "Play":
                        vm.Play();
                        break;
                    case "Instructions":
                        vm.ShowInstructions();
                        break;
                    case "Quit":
                        vm.QuitGame();
                        break;
                    default:
                        break;
                }
            }
        }
        MainMenuViewModel vm = new MainMenuViewModel();

    }
}
