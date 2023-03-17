using Domain.Core.Repositories;
using Domain.UniversityCollaborations.DTOs;
using Domain.UniversityCollaborations.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UniversityCollaborations.Repositories
{
    internal class UniversityCollaborationRepository : IUniversityCollaborationRepository
    {
        private readonly UniversityCollaborationDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public UniversityCollaborationRepository(UniversityCollaborationDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }



        public async Task<IEnumerable<UniversityCollaborationDTO>> GetAllAsync()
        {
            return await _dbContext.UniversityCollaborations.Select(t => new UniversityCollaborationDTO(t.Id, t.CollaboratorUniversity,t.UniversityGroup,t.CollaboratorGroupUniversity)).ToListAsync();
        }

        public async Task<IEnumerable<UniversityCollaboration>> GetAllByIdGroupAsync(int GroupId)
        {
            return await _dbContext.UniversityCollaborations.Where(t => t.Id != null && t.UniversityGroup != null).ToListAsync();
        }

        public async Task<UniversityCollaboration?> GetByIdAsync(int id)
        {
            return await _dbContext.UniversityCollaborations
                .FirstOrDefaultAsync(t => t.Id == id);
        }


        /// <summary>
        /// Saves aggregate and commits changes
        /// </summary>
        public async Task SaveAsync(UniversityCollaboration investigationProject)
        {
            _dbContext.Update(investigationProject);
            await _dbContext.SaveEntitiesAsync();
        }
    }
}
