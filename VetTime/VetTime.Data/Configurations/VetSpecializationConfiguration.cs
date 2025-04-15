using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetTime.Data.Models;

namespace VetTime.Data.Configurations
{
    public class VetSpecializationConfiguration : IEntityTypeConfiguration<VetSpecialization>
    {
        public void Configure(EntityTypeBuilder<VetSpecialization> builder)
        {
            builder
                .HasKey(vs => new
                {
                    vs.VetId,
                    vs.Id
                });
        }
    }
}
