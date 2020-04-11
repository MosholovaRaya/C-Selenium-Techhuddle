using System;
using System.Collections.Generic;

namespace SmallJiraGroupPracticePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Member author = new Member(MemberRole.Manger);
            Ticket ticket1 = new Ticket("First Ticket", author, "test description", 5.30);
                    
        }
    }
}
