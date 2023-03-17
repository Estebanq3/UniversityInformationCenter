using Domain.Universities.Entities;
using Infrastructure.Core;
using Infrastructure.Universities.EntityMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Universities
{
    public class UniversityDbContext : ApplicationDbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options, ILogger<UniversityDbContext> logger) : base(options, logger)
        {
        }
        public DbSet<University> University { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UniversityMap());
        }
    }
}
