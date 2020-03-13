using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Services
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Movie>> GetAllMoviesService()
        {
            return _context.Movie.Include(m => m.Director).ToList();
        }
        
        public async Task<Movie> GetMovieByIdService(int id)
        {
            return _context.Movie.FirstOrDefault(m => m.Id == id);
        }

        public async Task<List<Movie>> AddMovieService(Movie newMovie)
        {
            await _context.AddAsync(newMovie);
            await _context.SaveChangesAsync();
            
            return _context.Movie.ToList();
        }

        public async Task<Movie> UpdateMovieService(int id, Movie updateMovie)
        {
            Movie movie = _context.Movie.FirstOrDefault(m => m.Id == id);
            movie.Title = updateMovie.Title;
            movie.Rating = updateMovie.Rating;
            movie.Genre = updateMovie.Genre;
            await _context.SaveChangesAsync();
            
            return _context.Movie.FirstOrDefault(m => m.Id == id);
        }
        
        public async Task<Movie> DeleteMovieService(int id)
        {
            Movie movie = _context.Movie.First(m => m.Id == id);
            Movie deletedMovie = movie;
            _context.Remove(movie);
            await _context.SaveChangesAsync();
            
            return deletedMovie;
        }
    }
}