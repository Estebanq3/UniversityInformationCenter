using Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InvestigationCenters.Entities
{
    public class InvestigationCenter : AggregateRoot
    {
        public String Name { get; }
        public String Link { get; }
        public int UniversityId { get; }
        public int DepartmentId { get; }

        public InvestigationCenter(String name, String link, int universityId, int departmentId)
        {
            Name = name;
            Link = link;
            UniversityId = universityId;
            DepartmentId = departmentId;
        }
    }
}
