using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers
{
    [Route("/api/home")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var value = new { id = 1 };
            return Ok(value);
        }
    }
}
