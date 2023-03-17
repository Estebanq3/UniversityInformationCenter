using Application.Universities;
using Application.Universities.Implementations;

using Application.InvestigationCenters;
using Application.InvestigationCenters.Implementations;

using Application.InvestigationGroups;
using Application.InvestigationGroups.Implementation;

using Application.UniversityCollaborations;
using Application.UniversityCollaborations.Implementations;

using Application.Departments;
using Application.Departments.Implementations;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IUniversitiesService, UniversitiesService>();
            services.AddTransient<IInvestigationCentersService, InvestigationCentersService>();
            services.AddTransient<IInvestigationGroupsService, InvestigationGroupsService>();
            services.AddTransient<IInvestigationGroupsService, InvestigationGroupsService>();
            services.AddTransient<IUniversityCollaborationsService, UniversityCollaborationsService>();
            services.AddTransient<IDepartmensService, DepartmentsService>();
            return services;
        }
    }
}
