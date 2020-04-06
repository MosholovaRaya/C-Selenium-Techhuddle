using System;
using System.Collections.Generic;
using System.Text;

namespace JiraProject
{
    class TeamMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public int YearsOfExperience { get; set; }
        public TeamMemberRole Role { get; set; }

        public TeamMember(TeamMemberRole role)
        {
            Role = role;
        }
    }
    enum TeamMemberRole { ProjectManager, Programmer, QA }
}
