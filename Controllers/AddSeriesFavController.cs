using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/addFavSer")]
public class AddSeriesFavController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AddSeriesFavController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] SerieFavs addSerieMovie)
    {

        var serie = new SerieFavs
        {
            serieId = addSerieMovie.serieId,
            userId = addSerieMovie.userId
        };

        _context.series_favorites.Add(serie);
        await _context.SaveChangesAsync();
        return Ok("Serie Added");
    }
}