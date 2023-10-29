using Kaizen.Core;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers
{
    [ApiController]
    public class RegisterController : Controller
    {
        private readonly KaizenDbContext _context;
        public RegisterController(KaizenDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserController user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Created("", user);
        }
    }
}
