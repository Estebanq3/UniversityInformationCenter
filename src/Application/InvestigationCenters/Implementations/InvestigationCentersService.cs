using Domain.Core.Repositories;
using Domain.InvestigationCenters.DTOs;
using Domain.InvestigationCenters.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InvestigationCenters.Implementations
{
    internal class InvestigationCentersService : IInvestigationCentersService
    {
        private readonly IInvestigationCenterRepository _investigationCenterRepository;
        public InvestigationCentersService(IInvestigationCenterRepository investigationCenterRepository)
        {
            _investigationCenterRepository = investigationCenterRepository;
        }
        public async Task<InvestigationCenter?> GetInvestigationCentersByIdAsync(int id)
        {
            return await _investigationCenterRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<InvestigationCenter>> GetInvestigationCentersByUniversityIdAsync(int id)
        {
            return await _investigationCenterRepository.GetByIdUniversityAsync(id);
        }

        public async Task<IEnumerable<InvestigationCenterDTO>> GetInvestigationCentersAsync()
        {
            return await _investigationCenterRepository.GetAllAsync();
        }
    }
}
