using Domain.Core.Helpers;
using Domain.Core.ValueObjects;
using Domain.InvestigationGroups.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.InvestigationGroups.EntityMappings
{
    public class InvestigationGroupMap : IEntityTypeConfiguration<InvestigationGroup>
    {
        public void Configure(EntityTypeBuilder<InvestigationGroup> builder)
        {
            builder.ToTable("InvestigationGroup");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(p => p.Number)
                   .IsRequired()
                   .HasMaxLength(30);
            builder.Property(p => p.Link)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(p => p.InvestigationCenterId)
                   .IsRequired();
            builder.Property(p => p.UniversityId)
                   .IsRequired();
            builder.Property(p => p.DepartmentId)
                   .IsRequired();
        }
    }
}
