using Domain.UniversityCollaborations.Entities;
using Infrastructure.Core;
using Infrastructure.UniversityCollaborations.EntityMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UniversityCollaborations
{
    public class UniversityCollaborationDbContext : ApplicationDbContext
    {
        public UniversityCollaborationDbContext(DbContextOptions<UniversityCollaborationDbContext> options, ILogger<UniversityCollaborationDbContext> logger) : base(options, logger)
        {
        }

        public DbSet<UniversityCollaboration> UniversityCollaborations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UniversityCollaborationMap());
        }
    }
}
