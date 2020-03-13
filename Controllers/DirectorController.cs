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
        
        [HttpPost("/addDirector")]
        public async Task<IActionResult> AddDirector(Director newDirector)
        {
            return Ok(await _directorService.AddDirectorService(newDirector));
        }
        
    }
}