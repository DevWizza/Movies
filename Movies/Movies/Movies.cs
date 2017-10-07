using Movies.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class NavigationParametersKey
    {
        public readonly static string SelectedMovieId = nameof(SelectedMovieId);
        public readonly static string SelectedCategoryId = nameof(SelectedCategoryId);
    }

    public class ProjectJSONPaths
    {
        //assembly/folder/fileName.{extension}
        public readonly static string MoviesJSON = "Movies.MoviesJSON.movies.json";
    }
}
