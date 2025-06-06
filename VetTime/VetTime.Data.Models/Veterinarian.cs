﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VetTime.Data.Models
{
    public class Veterinarian
    {
        public Veterinarian()
        {
            Id= Guid.NewGuid();
            Ratings = new HashSet<Rating>();
            Appointments = new HashSet<Appointment>();
            VetSpecializations=new HashSet<VetSpecialization>();
            CreatedOn = DateTime.Now;
            IsDeleted = false;
        }

        [Required]
        [Key]
        public Guid Id { get; init; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [ForeignKey(nameof(Address))]
        [Required]
        public Guid AddressId { get; set; }
        public Address Address { get; set; }= null!;

        [ForeignKey(nameof(User))]
        [Required]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

        public ICollection<VetSpecialization> VetSpecializations { get; set; }

        public DateTime CreatedOn { get; init; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }

    }
}
