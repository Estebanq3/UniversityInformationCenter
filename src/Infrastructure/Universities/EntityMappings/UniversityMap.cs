using Domain.Core.Helpers;
using Domain.Core.ValueObjects;
using Domain.Universities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Universities.EntityMappings
{
    public class UniversityMap : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.ToTable("University");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(p => p.Link)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(p => p.Country)
                  .IsRequired()
                  .HasMaxLength(100);
        }
    }
}
