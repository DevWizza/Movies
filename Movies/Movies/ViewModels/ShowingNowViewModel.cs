using Movies.Models;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Movies.ViewModels
{
    public class ShowingNowViewModel : BindableBase, INavigationAware
    {
        public bool IsLoading { get; set; }

        public Movie SelectedMovie { get; set; }

        public IList<Movie> Movies { get; set; }

        public ICommand SelectedCommand { get; set; }

        public ShowingNowViewModel()
        {
            SelectedCommand = new Command<Movie>(OnMovieSelected);
        }

        private void OnMovieSelected(Movie movie)
        {
            if (movie == null)
                return;

            //TODO: navigate to the detail

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
                    Image = "https://cdn.pixabay.com/photo/2017/08/19/10/00/eagle-2657888_960_720.jpg"
                },
                new Movie
                {
                    Id = 1,
                    Score = 5,
                    Title = "Wonder Woman",
                    Genre = "Fantasy",
                    Rating = "PG-13",
                    Image = "https://cdn.pixabay.com/photo/2017/08/23/08/33/cats-eyes-2671903_960_720.jpg"
                },
                new Movie
                {
                    Id = 2,
                    Score = 2,
                    Title = "Toy Story 3",
                    Genre = "Fantasy",
                    Rating = "G",
                    Image = "https://cdn.pixabay.com/photo/2017/04/06/09/37/toy-2207781_960_720.jpg"
                }
            };

            IsLoading = false;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
