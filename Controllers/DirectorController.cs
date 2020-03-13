using System.Threading.Tasks;
using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{   
    [ApiController]
    [Route("/")]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorService _directorService;

        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }
        
        [HttpGet("/directors")]
        public async Task<IActionResult> GetAllDirectors()
        {
            return Ok(await _directorService.GetAllDirectorsService());
        }
        
        [HttpGet("/director/{id}")]
        public async Task<IActionResult> GetDirectorById(int id)
        {
            return Ok(await _directorService.GetDirectorByIdService(id));
        }
        
        [HttpPost("/director")]
        public async Task<IActionResult> AddDirector(Director newDirector)
        {
            return Ok(await _directorService.AddDirectorService(newDirector));
        }

        [HttpPut("/director/{id}")]
        public async Task<IActionResult> UpdateDirector(int id, Director updateDirector)
        {
            return Ok(await _directorService.UpdateDirectorService(id, updateDirector));
        }
        
    }
}