using Domain.Core.Repositories;
using Domain.InvestigationGroups.DTOs;
using Domain.InvestigationGroups.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.InvestigationGroups.Implementation
{
    internal class InvestigationGroupsService : IInvestigationGroupsService
    {
        private readonly IInvestigationGroupRepository _investigationGroupsRepository;
        public InvestigationGroupsService(IInvestigationGroupRepository investigationProjectRepository)
        {
            _investigationGroupsRepository = investigationProjectRepository;
        }
        public async Task<InvestigationGroup?> GetInvestigationGroupsByIdAsync(int id)
        {
            return await _investigationGroupsRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<InvestigationGroup>> GetInvestigationGroupsByCenterIdAsync(int universityId,int id)
        {
            return await _investigationGroupsRepository.GetByIdCenterAsync(universityId,id);
        }

        public async Task<IEnumerable<InvestigationGroupDTO>> GetInvestigationGroupsAsync()
        {
            return await _investigationGroupsRepository.GetAllAsync();
        }
    }
}
