using System;

namespace SmallJiraGroupPracticePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Member author = new Member(MemberRole.Manger);
            Ticket ticket1 = new Ticket("First Ticket", author, "test description", 5.30);

            Backlog backlog = new Backlog();
            backlog.Tickets.Add(ticket1);

        }
    }
}
