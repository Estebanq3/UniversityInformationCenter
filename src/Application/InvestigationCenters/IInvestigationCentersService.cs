using Domain.InvestigationCenters.DTOs;
using Domain.InvestigationCenters.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InvestigationCenters
{
    public interface IInvestigationCentersService
    {
        Task<IEnumerable<InvestigationCenterDTO>> GetInvestigationCentersAsync();
        Task<InvestigationCenter?> GetInvestigationCentersByIdAsync(int id);
        Task<IEnumerable<InvestigationCenter>> GetInvestigationCentersByUniversityIdAsync(int id);
    }
}
