using System.ComponentModel.DataAnnotations;

namespace Store_movie.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
