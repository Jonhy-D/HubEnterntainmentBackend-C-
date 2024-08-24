using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class MovieFavs
{
    [Key]
    public required int movieId {get; set;}
    public required int userId {get; set;}
}