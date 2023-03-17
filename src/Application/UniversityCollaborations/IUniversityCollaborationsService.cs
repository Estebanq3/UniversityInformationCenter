using Domain.UniversityCollaborations.DTOs;
using Domain.UniversityCollaborations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UniversityCollaborations
{
    public interface IUniversityCollaborationsService
    {
        Task<IEnumerable<UniversityCollaborationDTO>> GetUniversityCollaborationsAsync();
        Task<UniversityCollaboration?> GetUniversityCollaborationsByIdAsync(int id);
        Task<IEnumerable<UniversityCollaboration>> GetCollaborationsByIdGroupAsync(int groupId);
    }
}