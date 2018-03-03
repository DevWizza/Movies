using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Models;
using System.Windows.Input;
using Xamarin.Forms;
using Movies.Views;

namespace Movies.ViewModels
{
    public class CategoriesViewModel : BindableBase, INavigationAware
    {
        public bool IsLoading { get; set; }

        public Category SelectedCategory { get; set; }

        public IList<Category> Categories { get; set; }

        public ICommand SelectedCommand { get; set; }

        readonly INavigationService _navigationService;

        public CategoriesViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            SelectedCommand = new Command<Category>(OnCategorySelected);
        }

        async void OnCategorySelected(Category category)
        {
            if (category == null)
                return;

            var navigationParameters = new NavigationParameters();
            navigationParameters.Add(NavigationParametersKey.SelectedCategoryId, category.Title);

            await _navigationService.NavigateAsync($"{nameof(SearchResults)}", navigationParameters);

            SelectedCategory = null;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
             
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Categories = new List<Category>
            {
                new Category
                {
                    Title = "Fantasy",
                    Image = "fantasy"
                },
                new Category
                {
                    Title = "Thriller",
                    Image = "thriller"
                },
                new Category
                {
                    Title = "Action",
                    Image = "action"
                },
                new Category
                {
                    Title = "Drama",
                    Image = "drama"
                },
                new Category
                {
                    Title = "Documentary",
                    Image = "documentary"
                }
            };
        }
    }
}
