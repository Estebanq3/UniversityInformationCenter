using Domain.Core.Repositories;
using Domain.Universities.DTOs;
using Domain.Universities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Universities.Implementations
{
    internal class UniversitiesService : IUniversitiesService
    {
        private readonly IUniversityRepository _universityRepository;
        public UniversitiesService(IUniversityRepository universityRepository)
        {
            _universityRepository = universityRepository;
        }
        public async Task<University?> GetUniversityByIdAsync(int id)
        {
            return await _universityRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<UniversityDTO>> GetUniversityAsync()
        {
            return await _universityRepository.GetAllAsync();
        }

        public async Task AddUniversityAsync(University university)
        {
             await _universityRepository.SaveAsync(university);
        }

        public async Task DeleteUniversity(int id)
        {
            await _universityRepository.DeleteUniversity(id);
        }

        public async Task UpdateUniversity(int id, string name, string link, string country)
        {
            await _universityRepository.UpdateAsync(id, name, link, country);
        }
    }
}
