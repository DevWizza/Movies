using Movies.Models;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using Movies.Services;

namespace Movies.ViewModels
{
    public class ShowingNowViewModel : BindableBase, INavigationAware
    {
        public bool IsLoading { get; set; }

        public Movie SelectedMovie { get; set; }

        public IList<Movie> Movies { get; set; }

        public ICommand SelectedCommand { get; set; }

        readonly INavigationService _navigationService;

        readonly IMovieService _movieService;

        public ShowingNowViewModel(INavigationService navigationService, 
                                   IMovieService movieService)
        {
            _movieService = movieService;

            _navigationService = navigationService;

            SelectedCommand = new Command<Movie>(OnMovieSelected);
        }

        private async void OnMovieSelected(Movie movie)
        {
            if (movie == null)
                return;

            await _navigationService.NavigateAsync($"{Screens.ShowingNowNavigationPage}/{Screens.ShowingNow}/{Screens.MovieDetails}");

            SelectedMovie = null;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
             
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            IsLoading = true;

            Movies = await _movieService.GetMoviesAsync();

            IsLoading = false;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
