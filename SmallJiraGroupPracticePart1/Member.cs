using System;
using System.Collections.Generic;
using System.Text;

namespace SmallJiraGroupPracticePart1
{
    public enum MemberRole { Manger, Programmer, QA}
    class Member
    {
        private MemberRole role;

        public MemberRole Role { get; }
    }
}
