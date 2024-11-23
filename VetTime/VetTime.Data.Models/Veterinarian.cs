using System.ComponentModel.DataAnnotations;

namespace VetTime.Data.Models
{
    public class Veterinarian
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        //TODO:Navigation Properties
    }
}
