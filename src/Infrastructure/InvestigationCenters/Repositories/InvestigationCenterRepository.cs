using Domain.Core.Repositories;
using Domain.InvestigationCenters.DTOs;
using Domain.InvestigationCenters.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.InvestigationCenters.Repositories
{
    internal class InvestigationCenterRepository : IInvestigationCenterRepository
    {
        private readonly InvestigationCenterDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public InvestigationCenterRepository(InvestigationCenterDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }



        public async Task<IEnumerable<InvestigationCenterDTO>> GetAllAsync()
        {
            return await _dbContext.InvestigationCenters.Select(t => new InvestigationCenterDTO(t.Id, t.Name, t.Link,t.UniversityId,t.DepartmentId)).ToListAsync();
        }

        public async Task<InvestigationCenter?> GetByIdAsync(int id)
        {
            return await _dbContext.InvestigationCenters
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<InvestigationCenter>> GetByIdUniversityAsync(int id)
        {
            return await _dbContext.InvestigationCenters.Where(t => t.Id != null && t.UniversityId == id).ToListAsync();
        }

        /// <summary>
        /// Saves aggregate and commits changes
        /// </summary>
        public async Task SaveAsync(InvestigationCenter investigationProject)
        {
            _dbContext.Update(investigationProject);
            await _dbContext.SaveEntitiesAsync();
        }
    }
}
