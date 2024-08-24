using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/seriesFav")]

public class SeriesFavController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SeriesFavController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]

    public async Task<ActionResult<IEnumerable<Serie>>> GetFavorites([FromBody] UserId user)
    {
        var  query = from s in _context.Series
                    join sf in _context.series_favorites on s.serieId equals sf.serieId 
                    where sf.userId == user.userId
                    select new Serie
                    {
                        serieId = s.serieId,
                        serie_title = s.serie_title,
                        serie_description = s.serie_description,
                        serie_genre = s.serie_genre,
                        serie_image = s.serie_image
                    };
        await _context.SaveChangesAsync();
        return Ok(query);
    }
}