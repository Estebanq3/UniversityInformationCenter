using Domain.Departments.DTOs;
using Domain.Departments.Entities;
using Domain.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Repositories
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task SaveAsync(Department departments);
        Task<IEnumerable<DepartmentDTO>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
    }
}
