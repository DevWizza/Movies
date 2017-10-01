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
                    Image = "https://cdn.pixabay.com/photo/2017/08/31/11/39/iceland-2700427_960_720.jpg"
                },
                new Category
                {
                    Title = "Thriller",
                    Image = "https://cdn.pixabay.com/photo/2017/08/02/01/34/locket-2569573_960_720.jpg"
                },
                new Category
                {
                    Title = "Action",
                    Image = "https://cdn.pixabay.com/photo/2016/01/27/14/22/orange-1164504_960_720.jpg"
                },
                new Category
                {
                    Title = "Drama",
                    Image = "https://cdn.pixabay.com/photo/2017/09/06/18/22/island-2722471_960_720.jpg"
                },
                new Category
                {
                    Title = "Documentary",
                    Image = "https://cdn.pixabay.com/photo/2014/04/22/21/51/landscape-330112_960_720.jpg"
                }
            };
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
             
        }
    }
}
