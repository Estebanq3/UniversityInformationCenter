using Domain.Core.Repositories;

using Infrastructure.Universities;
using Infrastructure.Universities.Repositories;

using Infrastructure.InvestigationCenters;
using Infrastructure.InvestigationCenters.Repositories;

using Infrastructure.InvestigationGroups;
using Infrastructure.InvestigationGroups.Repositories;

using Infrastructure.UniversityCollaborations;
using Infrastructure.UniversityCollaborations.Repositories;


using Infrastructure.Departments;
using Infrastructure.Departments.Repositories;


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UniversityDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUniversityRepository, UniversityRepository>();

            services.AddDbContext<InvestigationCenterDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IInvestigationCenterRepository, InvestigationCenterRepository>();

            services.AddDbContext<InvestigationGroupDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IInvestigationGroupRepository, InvestigationGroupRepository>();

            services.AddDbContext<UniversityCollaborationDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUniversityCollaborationRepository, UniversityCollaborationRepository>();

            services.AddDbContext<DepartmentsDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            return services;
        }
    }
}
