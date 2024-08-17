using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("/auth")]
public class UsersAuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsersAuthController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CheckUser([FromBody] AuthUser authUser)
    {
        
       var user = await _context.Users.FirstOrDefaultAsync(u => u.email_address == authUser.email_address & u.user_password == authUser.user_password);
        if(user == null)
        {
            return NotFound($"User not found");
        }

        return StatusCode(200, user.userId);
    }
}