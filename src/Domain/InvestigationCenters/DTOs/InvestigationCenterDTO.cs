using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InvestigationCenters.DTOs
{
    public class InvestigationCenterDTO
    {
        public int Id { get; }
        public String Name { get; }
        public String Link { get; }
        public int UniversityId { get; }
        public int DepartmentId { get; }

        public InvestigationCenterDTO(int id, String name, String link, int universityId, int departmentId)
        {
            Id = id;
            Name = name;
            Link = link;
            UniversityId = universityId;
            DepartmentId = departmentId;
        }
    }
}
