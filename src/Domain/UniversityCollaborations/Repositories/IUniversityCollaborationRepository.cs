using Domain.UniversityCollaborations.DTOs;
using Domain.UniversityCollaborations.Entities;

using Domain.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Core.Repositories
{
    public interface IUniversityCollaborationRepository : IRepository<UniversityCollaboration>
    {
        Task SaveAsync(UniversityCollaboration investigationProjects);
        Task<IEnumerable<UniversityCollaborationDTO>> GetAllAsync();
        Task<IEnumerable<UniversityCollaboration>> GetAllByIdGroupAsync(int GroupId);
        Task<UniversityCollaboration?> GetByIdAsync(int id);
    }
}
