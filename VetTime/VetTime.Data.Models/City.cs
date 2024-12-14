﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetTime.Data.Models
{
    public class City
    {
        public City()
        {
            Id= Guid.NewGuid();
            Addresses=new HashSet<Address>();
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public ICollection<Address> Addresses { get; set; }
    }
}
