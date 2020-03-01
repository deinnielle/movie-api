using System.Collections.Generic;
using System.Linq;
using Api.Data;
using Api.Models;

namespace Api.Services
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public List<Movie> GetAllMoviesService()
        {
            return _context.Items.ToList();
        }
        
        public Movie GetMovieByIdService(int id)
        {
            return _context.Items.FirstOrDefault(m => m.Id == id);
        }

        public List<Movie> AddMovieService(Movie newMovie)
        {
            _context.Add(newMovie);
            _context.SaveChanges();
            return _context.Items.ToList();;
        }

        public Movie UpdateMovieService(int id, Movie updateMovie)
        {
            Movie movie = _context.Items.FirstOrDefault(m => m.Id == id);
            movie.Title = updateMovie.Title;
            movie.Rating = updateMovie.Rating;
            movie.Genre = updateMovie.Genre;
            _context.SaveChanges();
            
            return _context.Items.FirstOrDefault(m => m.Id == id);
        }
        
        public Movie DeleteMovieService(int id)
        {
            Movie movie = _context.Items.First(m => m.Id == id);
            Movie deletedMovie = movie;
            _context.Remove(movie);
            _context.SaveChanges();
            
            return deletedMovie;
        }
    }
}