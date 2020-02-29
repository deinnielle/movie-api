using System.Collections.Generic;
using Api.Models;

namespace Api.Services
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        List<Movie> AddMovie(Movie newMovie);
    }
}