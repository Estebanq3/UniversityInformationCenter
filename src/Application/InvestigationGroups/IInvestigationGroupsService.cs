using Domain.InvestigationGroups.DTOs;
using Domain.InvestigationGroups.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InvestigationGroups
{
    public interface IInvestigationGroupsService
    {
        Task<IEnumerable<InvestigationGroupDTO>> GetInvestigationGroupsAsync();
        Task<InvestigationGroup?> GetInvestigationGroupsByIdAsync(int id);
        Task<IEnumerable<InvestigationGroup>> GetInvestigationGroupsByCenterIdAsync(int universityId,int id);
    }
}
