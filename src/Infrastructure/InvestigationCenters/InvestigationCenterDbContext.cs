using Domain.InvestigationCenters.Entities;
using Infrastructure.Core;
using Infrastructure.InvestigationCenters.EntityMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.InvestigationCenters
{
    public class InvestigationCenterDbContext : ApplicationDbContext
    {
        public InvestigationCenterDbContext(DbContextOptions<InvestigationCenterDbContext> options, ILogger<InvestigationCenterDbContext> logger) : base(options, logger)
        {
        }

        public DbSet<InvestigationCenter> InvestigationCenters { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new InvestigationCenterMap());
        }
    }
}
