using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace Movies.ViewModels
{
    public class AboutMeViewModel : BindableBase, INavigationAware
    {
        public string ACoolPictureOfMe { get; set; }

        public AboutMeViewModel()
        {
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
