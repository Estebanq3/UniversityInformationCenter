using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Departments.DTOs
{
    public class DepartmentDTO
    {
        public int Id { get; }
        public String Name { get; }
        public int UniversityId { get; }

        public DepartmentDTO(int id, String name, int universityId)
        {
            Id = id;
            Name = name;
            UniversityId = universityId;
        }
    }
}
