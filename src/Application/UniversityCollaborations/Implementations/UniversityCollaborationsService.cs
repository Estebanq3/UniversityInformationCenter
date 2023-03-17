using Domain.Core.Repositories;
using Domain.UniversityCollaborations.DTOs;
using Domain.UniversityCollaborations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UniversityCollaborations.Implementations
{
    internal class UniversityCollaborationsService : IUniversityCollaborationsService
    {
        private readonly IUniversityCollaborationRepository _universityCollaborationRepository;
        public UniversityCollaborationsService(IUniversityCollaborationRepository investigationProjectRepository)
        {
            _universityCollaborationRepository = investigationProjectRepository;
        }
        public async Task<UniversityCollaboration?> GetUniversityCollaborationsByIdAsync(int id)
        {
            return await _universityCollaborationRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<UniversityCollaborationDTO>> GetUniversityCollaborationsAsync()
        {
            return await _universityCollaborationRepository.GetAllAsync();
        }

        public async Task<IEnumerable<UniversityCollaboration>> GetCollaborationsByIdGroupAsync(int groupId)
        {
            return await _universityCollaborationRepository.GetAllByIdGroupAsync(groupId);
        }
    }
}
