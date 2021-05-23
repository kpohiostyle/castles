using System.ComponentModel.DataAnnotations;

namespace castles.Models
{
    public class Castle
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int KnightCount { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public bool HasPrincess { get; set; }
        [Required]
        public bool HasDragon { get; set; }
    }
}