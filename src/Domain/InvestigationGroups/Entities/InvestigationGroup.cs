using Domain.Core.Entities;
using Domain.Core.Exceptions;
using Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InvestigationGroups.Entities
{
    public class InvestigationGroup : AggregateRoot
    {
        public String Name { get; }
        public String Number { get; }
        public String Link { get; }
        public int InvestigationCenterId { get; }
        public int UniversityId { get; }
        public int DepartmentId { get; }


        public InvestigationGroup(String name, String link, int investigationCenterId, int departmentId)
        {
            Name = name;
            Link = link;
            InvestigationCenterId = investigationCenterId;
            DepartmentId = departmentId;
        }
    }
}
