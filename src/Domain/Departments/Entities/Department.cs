using Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Departments.Entities
{
    public class Department : AggregateRoot
    {
        public String Name { get; }
        public int UniversityId { get; }

        public Department(String name, int universityId)
        {
            Name = name;
            UniversityId = universityId;
        }
    }
}
