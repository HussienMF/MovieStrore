using System.ComponentModel.DataAnnotations;

namespace Store_movie.Models.Domain
{
    public class Genre
    {
        public int id { get; set; }
        [Required] 
        public string? GenreName { get; set; }
    }
}
