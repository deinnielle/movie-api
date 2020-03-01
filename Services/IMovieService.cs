using System.Collections.Generic;
using Api.Models;

namespace Api.Services
{
    public interface IMovieService
    {
        List<Movie> GetAllMoviesService();
        Movie GetMovieByIdService(int id);
        List<Movie> AddMovieService(Movie newMovie);
        Movie UpdateMovieService(int id, Movie updateMovie);
        Movie DeleteMovieService(int id);
    }
}