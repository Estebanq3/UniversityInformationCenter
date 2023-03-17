using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Universities.DTOs
{
    public class UniversityDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Link { get; set; }
        public String Country { get; set; }

        public UniversityDTO(int id, string name, string link, string country)
        {
            Id = id;
            Name = name;
            Link = link;
            Country = country;
        }

    }
}
