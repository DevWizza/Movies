using System;
using Movies.Models;
using Movies.Services;
using Prism.Mvvm;
using Prism.Navigation;

namespace Movies.ViewModels
{
    public class MovieDetailsViewModel : BindableBase, INavigationAware
    {
        readonly IMovieService _movieService;

        public Movie SelectedMovie { get; set; }

        public MovieDetailsViewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.TryGetValue(NavigationParametersKey.SelectedMovieId, out int selectedMovieId))
            {
                SelectedMovie = await _movieService.GetMovieByIdAsync(selectedMovieId);
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
