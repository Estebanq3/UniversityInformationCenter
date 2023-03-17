using Domain.Core.Repositories;
using Domain.Departments.DTOs;
using Domain.Departments.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Departments.Implementations
{
    internal class DepartmentsService : IDepartmensService
    {
        private readonly IDepartmentRepository _investigationDeparmentRepository;
        public DepartmentsService(IDepartmentRepository investigationDepartmentRepository)
        {
            _investigationDeparmentRepository = investigationDepartmentRepository;
        }
        public async Task<Department?> GetDepartmentsByIdAsync(int id)
        {
            return await _investigationDeparmentRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<DepartmentDTO>> GetDepartmentsAsync()
        {
            return await _investigationDeparmentRepository.GetAllAsync();
        }
    }
}
