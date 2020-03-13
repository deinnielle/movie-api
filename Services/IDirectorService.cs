using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Services
{
    public interface IDirectorService
    {
        /*Task<List<Movie>> GetAllMoviesService();
        Task<Movie> GetMovieByIdService(int id);*/
        Task<List<Director>> AddDirectorService(Director newDirector);
        // Task<Movie> UpdateMovieService(int id, Movie updateMovie);
        // Task<Movie> DeleteMovieService(int id);
    }
}