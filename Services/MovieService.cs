using System.Collections.Generic;
using System.Linq;
using Api.Models;

namespace Api.Services
{
    public class MovieService : IMovieService
    {
        private static List<Movie> movies = new List<Movie> {
            new Movie(),
            new Movie { Id = 1, Title = "Parasite", Rating = 9.9, Genre = "Comedy"}
        };
        
        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieById(int id)
        {
            return movies.FirstOrDefault(c => c.Id == id);
        }

        public List<Movie> AddMovie(Movie newMovie)
        {
            movies.Add(newMovie);
            return movies;
        }
    }
}