using System;
using System.Collections.Generic;
using System.Windows.Input;
using Movies.Models;
using Movies.Services;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using Movies.Views;

namespace Movies.ViewModels
{
    public class SearchResultsViewModel : BindableBase, INavigationAware
    {
        public bool IsLoading { get; set; }

        public bool IsDoingSearch { get; set; }

        public bool IfNoResult { get; set; }

        public Movie SelectedMovie { get; set; }

        public IList<Movie> Movies { get; set; }

        public ICommand SelectedCommand { get; set; }

        public string SearchResult { get; set; }

        readonly INavigationService _navigationService;

        readonly IMovieService _movieService;

        public string Title { get; set; }

        public SearchResultsViewModel(INavigationService navigationService,
                                   IMovieService movieService)
        {
            _movieService = movieService;

            _navigationService = navigationService;

            SelectedCommand = new Command<Movie>(OnMovieSelected);
        }


        async void OnMovieSelected(Movie movie)
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

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            IsLoading = true;

            if (parameters.TryGetValue(NavigationParametersKey.SelectedCategoryId, out string selectedCategoryId))
            {
                Movies = await _movieService.GetMoviesByCategory(selectedCategoryId);

                IsDoingSearch = true;

                var howManyMoviesFound = Movies.Count();

                IfNoResult = howManyMoviesFound == 0;

                Title = (howManyMoviesFound == 0 ? "No" : howManyMoviesFound.ToString()) + " Results";

                SearchResult = $"Showing results for “{selectedCategoryId}” movies.";
            }
            IsLoading = false;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}