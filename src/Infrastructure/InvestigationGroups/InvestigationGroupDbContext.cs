using Domain.InvestigationGroups.Entities;
using Infrastructure.Core;
using Infrastructure.InvestigationGroups.EntityMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.InvestigationGroups
{
    public class InvestigationGroupDbContext : ApplicationDbContext
    {
        public InvestigationGroupDbContext(DbContextOptions<InvestigationGroupDbContext> options, ILogger<InvestigationGroupDbContext> logger) : base(options, logger)
        {
        }

        public DbSet<InvestigationGroup> InvestigationGroups { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new InvestigationGroupMap());
        }
    }
}
