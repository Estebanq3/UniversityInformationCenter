using Domain.Core.Repositories;
using Domain.Departments.DTOs;
using Domain.Departments.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Departments.Repositories
{
    internal class DepartmentRepository : IDepartmentRepository
    {
        private readonly DepartmentsDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public DepartmentRepository(DepartmentsDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }



        public async Task<IEnumerable<DepartmentDTO>> GetAllAsync()
        {
            return await _dbContext.Departments.Select(t => new DepartmentDTO(t.Id, t.Name, t.UniversityId)).ToListAsync();
        }

        public async Task<Department?> GetByIdAsync(int id)
        {
            return await _dbContext.Departments
                .FirstOrDefaultAsync(t => t.Id == id);
        }


        /// <summary>
        /// Saves aggregate and commits changes
        /// </summary>
        public async Task SaveAsync(Department department)
        {
            _dbContext.Update(department);
            await _dbContext.SaveEntitiesAsync();
        }
    }
}
