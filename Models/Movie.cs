using System.ComponentModel.DataAnnotations;

namespace Blockbuster.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DirectorName { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
    }
}
