using Domain.Core.Helpers;
using Domain.Core.ValueObjects;
using Domain.InvestigationCenters.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.InvestigationCenters.EntityMappings
{
    public class InvestigationCenterMap : IEntityTypeConfiguration<InvestigationCenter>
    {
        public void Configure(EntityTypeBuilder<InvestigationCenter> builder)
        {
            builder.ToTable("InvestigationCenter");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(p => p.Link)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(p => p.UniversityId)
                   .IsRequired();
            builder.Property(p => p.DepartmentId)
                   .IsRequired();
        }
    }
}
