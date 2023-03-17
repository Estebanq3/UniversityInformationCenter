using Domain.Core.Repositories;
using Domain.Universities.DTOs;
using Domain.Universities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Universities.Repositories
{
    internal class  UniversityRepository : IUniversityRepository
    {
        private readonly UniversityDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public UniversityRepository(UniversityDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }



        public async Task<IEnumerable<UniversityDTO>> GetAllAsync()
        {
            return await _dbContext.University.Select(t => new UniversityDTO(t.Id, t.Name, t.Link,t.Country)).ToListAsync();
        }

        public async Task<University?> GetByIdAsync(int id)
        {
            return await _dbContext.University
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        /// <summary>
        /// Saves aggregate and commits changes
        /// </summary>
        public async Task SaveAsync(University University)
        {
            _dbContext.Update(University);
            await _dbContext.SaveEntitiesAsync();
        }

        public Task DeleteUniversity(int id)
        {
            var _universityid = (from t in _dbContext.University
                             where t.Id == id
                             select t);
            _dbContext.University.RemoveRange(_universityid);
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task UpdateAsync(int id,string name,string link, string country)
        {
            var _universityid = (from p in _dbContext.University
                              where p.Id == id
                              select p).SingleOrDefault();
            if (_universityid is not null)
            {
                _universityid.Name = name;
                _universityid.Link = link;
                _universityid.Country = country;
            }

            _dbContext.SaveChanges();
            await _dbContext.SaveEntitiesAsync();
        }
    }
}
