using Domain.Core.Helpers;
using Domain.Core.ValueObjects;
using Domain.UniversityCollaborations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UniversityCollaborations.EntityMappings
{
    public class UniversityCollaborationMap : IEntityTypeConfiguration<UniversityCollaboration>
    {
        public void Configure(EntityTypeBuilder<UniversityCollaboration> builder)
        {
            builder.ToTable("UniversityCollaborations");
            builder.Property(p => p.Id)
                   .IsRequired();
            builder.Property(p => p.CollaboratorUniversity)
                   .IsRequired();
            builder.Property(p => p.UniversityGroup)
                  .IsRequired();
            builder.Property(p => p.CollaboratorGroupUniversity)
                  .IsRequired();
        }
    }
}
