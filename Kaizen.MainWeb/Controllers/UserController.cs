using Kaizen.Core;
using Kaizen.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers;

[Route("api/user")]
[ApiController]
public class UserController : Controller
{
    private readonly KaizenDbContext _context;

    public UserController(KaizenDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var users = _context.Users.ToList();
        return Ok(users);
    }

    [HttpPost]
    public IActionResult Post([FromBody] User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return Created("", user);
    }
}
