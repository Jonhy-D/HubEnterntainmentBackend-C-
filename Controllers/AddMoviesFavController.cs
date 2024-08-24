using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/addFavMov")]
public class AddMoviesFavController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AddMoviesFavController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] MovieFavs addFavMovie)
    {

        var movie = new MovieFavs
        {
            movieId = addFavMovie.movieId,
            userId = addFavMovie.userId
        };

        _context.movies_favorites.Add(movie);
        await _context.SaveChangesAsync();
        return Ok("Movie Added");
    }
}