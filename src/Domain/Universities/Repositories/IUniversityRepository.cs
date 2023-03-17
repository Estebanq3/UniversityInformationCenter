using Domain.Universities.DTOs;
using Domain.Universities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Repositories
{
    public interface IUniversityRepository : IRepository<University>
    {
        Task SaveAsync(University university);
        Task<IEnumerable<UniversityDTO>> GetAllAsync();
        Task<University?> GetByIdAsync(int id);
        Task DeleteUniversity(int id);
        Task UpdateAsync(int id,string name, string link, string country);
    }
}
