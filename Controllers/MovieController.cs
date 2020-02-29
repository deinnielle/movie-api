using System.Collections.Generic;
using System.Linq;
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
        // private static Movie movie = new Movie();

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        
        [Route("movies")]
        public IActionResult Get()
        {
            return Ok(_movieService.GetAllMovies());
        }
        
        [HttpGet("movie/{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_movieService.GetMovieById(id));
        }
        
        [HttpPost]
        public IActionResult AddMovie(Movie newMovie)
        {
            return Ok(_movieService.AddMovie(newMovie));
        }
    }
}