using Movies.Views;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Movies.Services;
using Prism;
using Prism.Ioc;

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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterScreens(containerRegistry);
            RegisterServices(containerRegistry);
        }

        void RegisterScreens(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MoviesHomeTabbedPage>();
            containerRegistry.RegisterForNavigation<ShowingNow>();
            containerRegistry.RegisterForNavigation<Categories>();
            containerRegistry.RegisterForNavigation<SearchResults>();
            containerRegistry.RegisterForNavigation<MovieDetails>();
            containerRegistry.RegisterForNavigation<AboutMe>();
            containerRegistry.RegisterForNavigation<AboutMeNavigationPage>();
            containerRegistry.RegisterForNavigation<ShowingNowNavigationPage>();
            containerRegistry.RegisterForNavigation<CategoriesNavigationPage>();
        }

        void RegisterServices(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register(typeof(IMovieService), typeof(MovieService));
            containerRegistry.Register(typeof(IJsonReaderService), typeof(JsonReaderService));
            containerRegistry.Register(typeof(IFileService), typeof(FileService));
        }
    }
}
