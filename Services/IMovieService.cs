using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMoviesService();
        Task<Movie> GetMovieByIdService(int id);
        Task<List<Movie>> AddMovieService(Movie newMovie);
        Task<Movie> UpdateMovieService(int id, Movie updateMovie);
        Task<Movie> DeleteMovieService(int id);
    }
}