using Domain.Universities.DTOs;
using Domain.Universities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Universities
{
    public interface IUniversitiesService
    {
        Task<IEnumerable<UniversityDTO>> GetUniversityAsync();
        Task<University?> GetUniversityByIdAsync(int id);
        Task AddUniversityAsync(University university);
        Task DeleteUniversity(int id);
        Task UpdateUniversity(int id, string name, string link, string country);
    }
}
