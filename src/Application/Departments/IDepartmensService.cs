using Domain.Departments.DTOs;
using Domain.Departments.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Departments
{
    public interface IDepartmensService
    {
        Task<IEnumerable<DepartmentDTO>> GetDepartmentsAsync();
        Task<Department?> GetDepartmentsByIdAsync(int id);
    }
}
