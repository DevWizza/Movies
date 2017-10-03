using Movies.Views;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Movies.Services;
using Microsoft.Practices.Unity;

namespace Movies
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync(new Uri($"{Screens.AbsoluteURI}/{Screens.MoviesHomeTabbedPage}/{Screens.ShowingNowNavigationPage}/{Screens.ShowingNow}", UriKind.Absolute));
        }

        protected override void RegisterTypes()
        {
            RegisterScreens();
            RegisterServices();
        }

        void RegisterScreens()
        {
            Container.RegisterTypeForNavigation<MoviesHomeTabbedPage>();
            Container.RegisterTypeForNavigation<ShowingNow>();
            Container.RegisterTypeForNavigation<Categories>();
            Container.RegisterTypeForNavigation<SearchResults>();
            Container.RegisterTypeForNavigation<MovieDetails>();
            Container.RegisterTypeForNavigation<ShowingNowNavigationPage>();
            Container.RegisterTypeForNavigation<CategoriesNavigationPage>();
        }

        void RegisterServices()
        {
            Container.RegisterType(typeof(IMovieService), typeof(MovieService));
            Container.RegisterType(typeof(IJsonReaderService), typeof(JsonReaderService));
            Container.RegisterType(typeof(IFileService), typeof(FileService));
        }
    }
}
