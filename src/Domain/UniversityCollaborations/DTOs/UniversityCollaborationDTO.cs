using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversityCollaborations.DTOs
{
    public class UniversityCollaborationDTO
    {
        public int Id { get; }
        public int CollaboratorUniversity { get; }
        public int UniversityGroup { get; }
        public int CollaboratorGroupUniversity { get; }
        

        public UniversityCollaborationDTO(int id, int collaboratorUniversity,int universityGroup,int collaboratorGroupUniversity) {
            Id = id;
            CollaboratorUniversity = collaboratorUniversity;
            UniversityGroup = universityGroup;
            CollaboratorGroupUniversity = collaboratorGroupUniversity;
        }
    }
}
