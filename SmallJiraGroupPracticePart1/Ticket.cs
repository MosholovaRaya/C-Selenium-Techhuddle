using System;
using System.Collections.Generic;
using System.Text;

namespace SmallJiraGroupPracticePart1
{
    public enum TicketType { Task, Bug }

    public enum TicketStatus { ToDo, InProgress, ReadyForTesting, BeingTested, Done}
    class Ticket

    {
        private Guid id;
        private string title;
        private TicketType type;
        private Member assignee;
        private DateTime creationDate;
        private DateTime completionDate;
        private double estimationTime;
        private double completionTime;
        private TicketStatus status;
        private string description;
        private List<Comment> comments;
        private Member author;
    

        //Properties:
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
        public double CompletionTime { get; set;) }
      
        public TicketStatus Status { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; }
        public Member Author { get; }
     


        //Constructor

        public Ticket(string title, Member author, string description, double estimationTime)
        {
            this.id = Guid.NewGuid();
            this.title = title;
            this.type = (author.Role == MemberRole.QA) ? TicketType.Bug : TicketType.Task;
            this.creationDate = DateTime.Now;
            this.description = description;
            this.status = TicketStatus.ToDo;
            this.comments = new List<Comment>();
            this.estimationTime = estimationTime;
            this.completionTime = 0;
            
                
         }
        //Methods

        public void AddComment(Comment comment)
        {
            this.comments.Add(comment);

        }

        public void ChangeStatusToToDo()
        {
            
            if (this.status == TicketStatus.InProgress || this.status == TicketStatus.ReadyForTesting )
            {
                this.status = TicketStatus.ToDo;
            }
            else
            {
                throw new InvalidOperationException("Cannot perform this operation");
            }
        }
        public void ChangeStatusToInProgress()
        {
            if (this.assignee.Role == MemberRole.Programmer && this.status == TicketStatus.ToDo )
            {
                this.status = TicketStatus.ReadyForTesting;
            }
            else
            {
                throw new InvalidOperationException("You must have assignee of type programme");
            }
        }

        public void ChangeStatusToReadyForTesting()
        {
            this.status = TicketStatus.ToDo;
            this.assignee = null;
        }
        public void ChangeStatusToBeingTested ()
        {
            if (this.assignee.Role == MemberRole.QA && this.status == TicketStatus.ReadyForTesting)
            {
                this.status = TicketStatus.BeingTested;
            }
            else
            {
                throw new InvalidOperationException("You must have assignee of type QA");
            }
        }

        public void ChangeStatusToDone()
        {
            if (this.status == TicketStatus.BeingTested && this.assignee!=null && this.assignee.Role == MemberRole.QA)
            {
                this.status = TicketStatus.Done
            }
            else
            {
                throw new InvalidOperationException("You cannot move it to done if you're not a QA!!!!!!");
            }
        }
        public void LogTimeToTicket(double hours)
        {
            if (this.assignee!=null)
            {
                this.completionTime += hours ;
            }
        }
       

    }
}
