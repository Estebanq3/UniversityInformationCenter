using Domain.InvestigationGroups.DTOs;
using Domain.InvestigationGroups.Entities;

using Domain.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Repositories
{
    public interface IInvestigationGroupRepository : IRepository<InvestigationGroup>
    {
        Task SaveAsync(InvestigationGroup investigationGroup);
        Task<IEnumerable<InvestigationGroupDTO>> GetAllAsync();
        Task<InvestigationGroup?> GetByIdAsync(int id);
        Task<IEnumerable<InvestigationGroup>> GetByIdCenterAsync(int universityId, int id);
    }
}
