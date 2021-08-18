using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    // EL [controller] toma el nombredel controlador
    public class ChannelsController : ControllerBase
    {
        public IActionResult Get()
        {
            var channels = new string[] { "C#", "Java", "Python", "JavaScript" };
            return Ok(channels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(".NetCore");
        }
    }
}