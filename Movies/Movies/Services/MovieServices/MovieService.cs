using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Services
{
    public class MovieService : IMovieService
    {
        IList<Movie> _movies;

        readonly IJsonReaderService _jsonReaderService;

        public MovieService(IJsonReaderService jsonReaderService)
        {
            _jsonReaderService = jsonReaderService;
        }

        public async Task<Movie> GetMovieByIdAsync(int identifier)
        {
            if (_movies == null)
                await Init();

            return _movies.FirstOrDefault(movie => movie.Id == identifier);
        }

        public async Task<IList<Movie>> GetMoviesAsync()
        {
            if (_movies == null)
                await Init();

            return _movies;
        }

        public async Task<IList<Movie>> GetMoviesByCategory(string selectedCategoryId)
        {
            if (_movies == null)
                await Init();

            return new List<Movie>(_movies.Where(movie => movie.Genre.Equals(selectedCategoryId)));
        }

        async Task Init()
        {
            await Task.Delay(400);

            _movies = await _jsonReaderService.GetStringAsJsonObjectAsync<IList<Movie>>(ProjectJSONPaths.MoviesJSON);
        }
    }
}
