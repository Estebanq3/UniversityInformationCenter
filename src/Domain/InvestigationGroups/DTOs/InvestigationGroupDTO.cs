using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InvestigationGroups.DTOs
{
    public class InvestigationGroupDTO
    {
        public int Id { get; }
        public String Name { get; }
        public String Number { get; }
        public String Link { get; }
        public int InvestigationCenterId { get; }
        public int UniveristyId { get; }
        public int DepartmentId { get; }

        public InvestigationGroupDTO(int id, String name, String number, String link, int investigationCenterId, int universityId, int departmentId)
        {
            Id = id;
            Name = name;
            Number = number;
            Link = link;
            InvestigationCenterId = investigationCenterId;
            UniveristyId = universityId;
            DepartmentId = departmentId;
        }
    }
}
