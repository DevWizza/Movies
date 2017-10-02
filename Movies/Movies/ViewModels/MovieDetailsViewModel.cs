using System;
using Movies.Models;
using Prism.Mvvm;
using Prism.Navigation;

namespace Movies.ViewModels
{
    public class MovieDetailsViewModel : BindableBase, INavigationAware
    {

        public Movie SelectedMovie { get; set; }

        public MovieDetailsViewModel()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

            if (parameters.TryGetValue(NavigationParametersKey.SelectedMovieId, out string selectedMovieId))
            {

            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
