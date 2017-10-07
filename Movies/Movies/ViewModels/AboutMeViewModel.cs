using System;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace Movies.ViewModels
{
    public class AboutMeViewModel : BindableBase, INavigationAware
    {
        public string ACoolPictureOfMe { get; set; }

        public ICommand OpenPortfolioCommand { get; set; }

        public AboutMeViewModel()
        {
            OpenPortfolioCommand = new Command(OnOpenPortfolio);
        }

        void OnOpenPortfolio()
        {
            Device.OpenUri(new Uri("https://luisalbertopenanunez.github.io/"));
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            ACoolPictureOfMe = "luis.png";
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
