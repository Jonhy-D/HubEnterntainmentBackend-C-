using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

[ApiController]
[Route("/users")]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] NewUser newuser)
    {

        var user = new User
        {
            first_name = newuser.first_name,
            last_name = newuser.last_name,
            email_address = newuser.email_address,
            user_password = newuser.user_password
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return Ok(new {user.userId, user.last_name});
    }
}