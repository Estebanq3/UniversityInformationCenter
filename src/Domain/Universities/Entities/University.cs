using Domain.Core.Entities;
using Domain.Core.Exceptions;
using Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Universities.Entities
{
    public class University : AggregateRoot
    {
        public String Name { get; set; }
        public String Link { get; set; }
        public String Country { get; set; }

        public University(String name, String link, String country) {
            Name = name;
            Link = link;
            Country = country;
        }
    }
}
