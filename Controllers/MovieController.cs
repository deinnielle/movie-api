using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        
        [Route("/")]
        public async Task<IActionResult> GetAllMovies()
        {
            return Ok(await _movieService.GetAllMoviesService());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            return Ok(await _movieService.GetMovieByIdService(id));
        }
        
        [HttpPost]
        public async Task<IActionResult> AddMovie(Movie newMovie)
        {
            return Ok(await _movieService.AddMovieService(newMovie));
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, Movie updateMovie)
        {
            return Ok(await _movieService.UpdateMovieService(id, updateMovie));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            return Ok(await _movieService.DeleteMovieService(id));
        }
    }
}