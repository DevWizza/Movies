using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movies.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowingNowNavigationPage : NavigationPage
    {
        public ShowingNowNavigationPage(Page page) : base(page)
        {
            InitializeComponent();
        }
    }
}