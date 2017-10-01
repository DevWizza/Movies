using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottomBar.XamarinForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movies.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviesHomeTabbedPage : BottomBarPage
    {
        public MoviesHomeTabbedPage()
        {
            InitializeComponent();
        }
    }
}