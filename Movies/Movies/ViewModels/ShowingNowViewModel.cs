using Movies.Models;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System;

namespace Movies.ViewModels
{
    public class ShowingNowViewModel : BindableBase, INavigationAware
    {
        public bool IsLoading { get; set; }

        public Movie SelectedMovie { get; set; }

        public IList<Movie> Movies { get; set; }

        public ICommand SelectedCommand { get; set; }

        readonly INavigationService _navigationService;

        public ShowingNowViewModel(INavigationService navigationService)
        {
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

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            IsLoading = true;

            Movies = new List<Movie>
            {
                new Movie
                {
                    Id = 0,
                    Score = 4,
                    Title = "IT",
                    Genre = "Thriller",
                    Rating = "PG-13",
                    Image = "scarymovie"
                },
                new Movie
                {
                    Id = 1,
                    Score = 5,
                    Title = "Wonder Woman",
                    Genre = "Fantasy",
                    Rating = "PG-13",
                    Image = "wonderwoman"
                },
                new Movie
                {
                    Id = 2,
                    Score = 2,
                    Title = "Toy Story 3",
                    Genre = "Fantasy",
                    Rating = "G",
                    Image = "toystory3"
                },
                new Movie
                {
                    Id = 3,
                    Score = 5,
                    Title = "American Made",
                    Genre = "Drama",
                    Rating = "R",
                    Image = "americanmade"
                }
            };

            IsLoading = false;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
