using Movies.Views;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

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
            Container.RegisterTypeForNavigation<MoviesHomeTabbedPage>();
            Container.RegisterTypeForNavigation<ShowingNow>();
            Container.RegisterTypeForNavigation<Categories>();
            Container.RegisterTypeForNavigation<MovieDetails>();
            Container.RegisterTypeForNavigation<ShowingNowNavigationPage>();
            Container.RegisterTypeForNavigation<CategoriesNavigationPage>();
        }
    }
}
