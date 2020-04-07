using System;

namespace JiraProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember author = new TeamMember(TeamMemberRole.QA);
            Ticket t = new Ticket("Do this", author);

            Comment comment = new Comment();
            t.Comments.Add(comment);

            Console.WriteLine(t.Status);
        }
    }
}
