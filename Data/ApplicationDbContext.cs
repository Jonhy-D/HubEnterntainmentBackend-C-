using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){ }

    public DbSet<User> Users { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Serie> Series { get; set; }
    public DbSet<SerieFavs> series_favorites {get; set;}
    public DbSet<MovieFavs> movies_favorites {get; set;}
}