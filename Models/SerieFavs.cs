using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class SerieFavs
{
    [Key]
    public int serieId {get; set;}
    public int userId {get; set;}
}