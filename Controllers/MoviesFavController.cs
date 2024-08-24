using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/moviesFav")]

public class MoviesFavController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public MoviesFavController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]

    public async Task<ActionResult<IEnumerable<Movie>>> GetFavorites([FromBody] UserId user)
    {
        var  query = from m in _context.Movies
                    join mf in _context.movies_favorites on m.movieId equals mf.movieId
                    where mf.userId == user.userId
                    select new Movie
                    {
                        movieId = m.movieId,
                        movie_title = m.movie_title,
                        movie_description = m.movie_description,
                        movie_duration = m.movie_duration,
                        movie_genre = m.movie_genre,
                        movie_image = m.movie_image
                    };
        await _context.SaveChangesAsync();
        return Ok(query);
    }
}