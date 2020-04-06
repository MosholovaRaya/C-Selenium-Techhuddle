using System;
using System.Collections.Generic;
using System.Text;

namespace JiraProject
{
    class Ticket
    {
        public Guid Id { get; }
        public string Title { get; set; }
        public TeamMember Author { get; }
        public TicketType Type { get; set; }
        public TeamMember Assignee { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public double EstimatedTime { get; set; }
        public double CompletionTime { get; set; }
        public TicketStatus Status { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; }

        public Ticket(string title, TeamMember author)
        {
            Id = Guid.NewGuid();
            Author = author;
            Type = (author.Role == TeamMemberRole.QA) ? TicketType.Bug : TicketType.Task;
            CreationDate = DateTime.Now;
            Status = TicketStatus.ToDo;
            Title = title;
            Comments = new List<Comment>();
        }
    }
    enum TicketType { Task, Bug }
    enum TicketStatus { ToDo, InProgress, ReadyForTesting, BeingTested, Done}
}
