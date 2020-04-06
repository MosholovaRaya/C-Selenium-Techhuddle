using System;

namespace JiraProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember author = new TeamMember(TeamMemberRole.QA);
            Ticket t = new Ticket("Do this", author);

            Console.WriteLine(t.Status);
        }
    }
}
