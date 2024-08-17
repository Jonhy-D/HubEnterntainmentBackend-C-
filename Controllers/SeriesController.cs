using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

[ApiController]
[Route("/series")]

public class SeriesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SeriesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]

    public async Task<ActionResult<IEnumerable<Serie>>> GetSeries()
    {
        return await _context.Series.ToListAsync();
    }

}