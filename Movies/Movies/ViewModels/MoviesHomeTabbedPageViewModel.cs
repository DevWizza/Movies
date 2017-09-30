using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.ViewModels
{
    public class MoviesHomeTabbedPageViewModel : BindableBase, INavigationAware
    {
        public string ShowingNowTitle { get; set; }

        public string CategoriesTitle { get; set; }

        public ShowingNowViewModel ShowingNowViewModel { get; set; }

        public CategoriesViewModel CategoriesViewModel { get; set; }

        public MoviesHomeTabbedPageViewModel(ShowingNowViewModel showingNowViewModel,
            CategoriesViewModel categoriesViewModel)
        {
            ShowingNowViewModel = showingNowViewModel;
            CategoriesViewModel = categoriesViewModel;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            ShowingNowViewModel.OnNavigatedFrom(parameters);
            CategoriesViewModel.OnNavigatedFrom(parameters);
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            ShowingNowTitle = "Showing Now";

            CategoriesTitle = "Categories";

            ShowingNowViewModel.OnNavigatedTo(parameters);
            CategoriesViewModel.OnNavigatedTo(parameters);
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            ShowingNowViewModel.OnNavigatingTo(parameters);
            CategoriesViewModel.OnNavigatingTo(parameters);
        }
    }
}
