using Movies.Models;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using Movies.Services;
using System.Linq;
using Movies.Views;

namespace Movies.ViewModels
{
    public class ShowingNowViewModel : BindableBase, INavigationAware
    {
        public bool IsLoading { get; set; }

        public Movie SelectedMovie { get; set; }

        public IList<Movie> Movies { get; set; }

        public ICommand SelectedCommand { get; set; }

        public string SearchResult { get; set; }

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

            var navigationParameters = new NavigationParameters();
            navigationParameters.Add(NavigationParametersKey.SelectedMovieId, movie.Id);

            await _navigationService.NavigateAsync($"{nameof(MovieDetails)}", navigationParameters);

            SelectedMovie = null;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
             
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public async void OnNavigatingTo(NavigationParameters parameters)
        {
            IsLoading = true;

            Movies = await _movieService.GetMoviesAsync();

            IsLoading = false;
        }
    }
}