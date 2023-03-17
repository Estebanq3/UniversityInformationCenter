using Domain.InvestigationCenters.DTOs;
using Domain.InvestigationCenters.Entities;
using Domain.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Repositories
{
    public interface IInvestigationCenterRepository : IRepository<InvestigationCenter>
    {
        Task SaveAsync(InvestigationCenter investigationCenter);
        Task<IEnumerable<InvestigationCenterDTO>> GetAllAsync();
        Task<InvestigationCenter?> GetByIdAsync(int id);
        Task<IEnumerable<InvestigationCenter>> GetByIdUniversityAsync(int id);
    }
}
