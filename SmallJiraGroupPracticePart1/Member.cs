using System;
using System.Collections.Generic;
using System.Text;

namespace SmallJiraGroupPracticePart1
{
    public enum MemberRole { Manger, Programmer, QA}
    class Member
    {
        public MemberRole Role { get; }

        public Member(MemberRole role)
        {
            Role = role;
        }
    }
}
