using Domain.Core.Entities;
using Domain.Core.Exceptions;
using Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversityCollaborations.Entities
{
    public class UniversityCollaboration : AggregateRoot
    {
        public int Id { get; }
        public int CollaboratorUniversity { get; }
        public int UniversityGroup { get; }
        public int CollaboratorGroupUniversity { get; }
        public UniversityCollaboration(int id, int collaboratorUniversity, int universityGroup, int collaboratorGroupUniversity)
        {
            Id = id;
            CollaboratorUniversity = collaboratorUniversity;
            UniversityGroup = universityGroup;
            CollaboratorGroupUniversity = collaboratorGroupUniversity;
        }
    }
}
