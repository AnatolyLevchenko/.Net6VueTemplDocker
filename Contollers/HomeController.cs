using Microsoft.AspNetCore.Mvc;

namespace Example.Contollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController:ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Hello world");
        }
    }
}
