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

        public CategoriesViewModel()
        {
            SelectedCommand = new Command<Category>(OnCategorySelected);
        }

        void OnCategorySelected(Category category)
        {
            if (category == null)
                return;

            //TODO: navigate to the detail

            SelectedCategory = null;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
             
        }

        public void OnNavigatedTo(NavigationParameters parameters)
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

        public void OnNavigatingTo(NavigationParameters parameters)
        {
             
        }
    }
}
