using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Services
{
    public interface IMovieService
    {
        Task<IList<Movie>> GetMoviesAsync();

        Task<Movie> GetMovieByIdAsync(int identifier);

        Task<IList<Movie>> GetMoviesByCategory(string selectedCategoryId);
    }
}
