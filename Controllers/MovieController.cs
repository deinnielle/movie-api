using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static Movie video = new Movie();

        public IActionResult Get()
        {
            return Ok(video);
        }
    }
}