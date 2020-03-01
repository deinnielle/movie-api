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

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        
        [Route("/")]
        public IActionResult Get()
        {
            return Ok(_movieService.GetAllMoviesService());
        }
        
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_movieService.GetMovieByIdService(id));
        }
        
        [HttpPost]
        public IActionResult AddMovie(Movie newMovie)
        {
            return Ok(_movieService.AddMovieService(newMovie));
        }
        
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, Movie updateMovie)
        {
            return Ok(_movieService.UpdateMovieService(id, updateMovie));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            return Ok(_movieService.DeleteMovieService(id));
        }
    }
}