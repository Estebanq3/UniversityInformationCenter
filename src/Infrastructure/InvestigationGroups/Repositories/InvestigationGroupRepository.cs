using Domain.Core.Repositories;
using Domain.InvestigationGroups.DTOs;
using Domain.InvestigationGroups.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.InvestigationGroups.Repositories
{
    public class InvestigationGroupRepository : IInvestigationGroupRepository
    {
        private readonly InvestigationGroupDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public InvestigationGroupRepository(InvestigationGroupDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }



        public async Task<IEnumerable<InvestigationGroupDTO>> GetAllAsync()
        {
            return await _dbContext.InvestigationGroups.Select(t => new InvestigationGroupDTO(t.Id, t.Name, t.Number, t.Link,t.InvestigationCenterId, t.UniversityId,t.DepartmentId)).ToListAsync();
        }

        public async Task<InvestigationGroup?> GetByIdAsync(int id)
        {
            return await _dbContext.InvestigationGroups
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<InvestigationGroup>> GetByIdCenterAsync(int universityId, int id)
        {
            return await _dbContext.InvestigationGroups.Where(t => t.Id != null && t.InvestigationCenterId == id && t.UniversityId == universityId).ToListAsync();
        }



        /// <summary>
        /// Saves aggregate and commits changes
        /// </summary>
        public async Task SaveAsync(InvestigationGroup investigationProject)
        {
            _dbContext.Update(investigationProject);
            await _dbContext.SaveEntitiesAsync();
        }
    }
}
