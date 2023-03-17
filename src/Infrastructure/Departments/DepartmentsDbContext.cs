using Domain.Departments.Entities;
using Infrastructure.Core;
using Infrastructure.Departments.EntityMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Departments
{
    public class DepartmentsDbContext : ApplicationDbContext
    {
        public DepartmentsDbContext(DbContextOptions<DepartmentsDbContext> options, ILogger<DepartmentsDbContext> logger) : base(options, logger)
        {
        }

        public DbSet<Department> Departments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DepartmentMap());
        }
    }
}
