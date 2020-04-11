using System;
using System.Collections.Generic;
using System.Text;

namespace SmallJiraGroupPracticePart1
{
    public enum TicketType { Task, Bug }

    public enum TicketStatus { ToDo, InProgress, ReadyForTesting, BeingTested, Done}

    class Ticket
    {
        // Fields: in our case we need just one field because the 'Title' property is not auto-implemented
        private string title;

        // Properties
        public Guid Id { get; }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length <= 255)
                {
                    title = value;
                }
                else
                {
                    throw new InvalidOperationException("Title must be maximum 255 characters");
                }
            }
        }
        public TicketType Type { get; }
        public Member Assignee { get; set; }
        public DateTime CreationDate { get; }
        public DateTime CompletionDate { get; }
        public double EstimationTime{ get; set; }
        public double CompletionTime { get; set; }
      
        public TicketStatus Status { get; private set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; }
        public Member Author { get; }
     


        // Constructor

        public Ticket(string title, Member author, string description, double estimationTime)
        {
            Id = Guid.NewGuid();
            Title = title;
            Type = (author.Role == MemberRole.QA) ? TicketType.Bug : TicketType.Task;
            CreationDate = DateTime.Now;
            Description = description;
            Status = TicketStatus.ToDo;
            Comments = new List<Comment>();
            EstimationTime = estimationTime;
            CompletionTime = 0;
         }

        // Methods

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);

        }

        public void ChangeStatusToToDo()
        {
            
            if (Status == TicketStatus.InProgress || Status == TicketStatus.ReadyForTesting)
            {
                Status = TicketStatus.ToDo;
            }
            else
            {
                throw new InvalidOperationException("Cannot perform this operation");
            }
        }
        public void ChangeStatusToInProgress()
        {
            if (Assignee.Role == MemberRole.Programmer && Status == TicketStatus.ToDo)
            {
                Status = TicketStatus.InProgress;
            }
            else
            {
                throw new InvalidOperationException("You must have assignee of type programme");
            }
        }

        public void ChangeStatusToReadyForTesting()
        {
            Status = TicketStatus.ReadyForTesting;
            Assignee = null;
        }
        public void ChangeStatusToBeingTested ()
        {
            if (Assignee.Role == MemberRole.QA && Status == TicketStatus.ReadyForTesting)
            {
                Status = TicketStatus.BeingTested;
            }
            else
            {
                throw new InvalidOperationException("You must have assignee of type QA");
            }
        }

        public void ChangeStatusToDone()
        {
            if (Status == TicketStatus.BeingTested && Assignee!=null && Assignee.Role == MemberRole.QA)
            {
                Status = TicketStatus.Done;
            }
            else
            {
                throw new InvalidOperationException("You cannot move it to done if you're not a QA!!!!!!");
            }
        }
        public void LogTimeToTicket(double hours)
        {
            if (Assignee!=null)
            {
                CompletionTime += hours ;
            }
        }
       

    }
}
