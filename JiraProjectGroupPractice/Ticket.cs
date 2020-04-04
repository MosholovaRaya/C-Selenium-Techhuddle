using System;
using System.Collections.Generic;
using System.Text;

namespace JiraProjectGroupPractice
{
    public enum Type { Task; Bug }
    public enum Status { ToDo, InProgress, ReadyForTesting, BeingTested, Done }
    class Ticket
    {
        public int Id;
        public string TicketTitle;
        public Type TicketType;
        public Member Assignee;
        public DateTime CreationDate;
        public DateTime CompletionDate;
        public double EstimatedTime;
        public double CompletionTime;
        public Status Status;
        public string Description;
        public List<Comment> Comments;

        // Here we continue with the creation of a builder for our Ticket

        public Ticket (int Id, string TicketTitle, Type TicketType, Member Assignee, DateTime CreationDate, double EstimatedTime, Status Status, string Description)
        {
            this.Id = Id;
            this.TicketTitle = TicketTitle;
            this.TicketType = TicketType;
            this.Assignee = Assignee;
            this.CreationDate = CreationDate;
            this.EstimatedTime = EstimatedTime;
            this.Status = Status;
            this.Description = Description;
            this.Comments = new List<Comment>();

        }
        public void addComment(Comment Comment)
        {
            this.Comments.Add(Comment);
            // take the whole object as a whole

        }




    }
}
