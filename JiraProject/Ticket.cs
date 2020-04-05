using System;
using System.Collections.Generic;
using System.Text;

namespace JiraProject
{
    class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TicketType Type { get; set; }
        public TeamMember Assignee { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public double EstimatedTime { get; set; }
        public double CompletionTime { get; set; }
        public TicketStatus Status { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; }

        public Ticket ()
        {
            Comments = new List<Comment>();
        }



        
    }
    enum TicketType { Task, Bug }
    enum TicketStatus { ToDo, InProgress, ReadyForTesting, BeingTested, Done}
}
