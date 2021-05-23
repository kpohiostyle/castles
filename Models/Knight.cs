using System.ComponentModel.DataAnnotations;

namespace castles.Models
{
    public class Knight
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DragonsSlain { get; set; }
        [Required]
        public string WeaponType { get; set; }
    }
}