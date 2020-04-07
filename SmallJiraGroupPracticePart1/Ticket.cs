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
        public double CompletionTime
        {
            get
            {
                return (completionDate - creationDate).TotalHours;
            }
         }
        public TicketStatus Status { get; set; }
        private string Description { get; set; }
        private List<Comment> Comments { get; }
        private Member Author { get; }

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
                
         }

        public void AddComment(Comment comment)
        {
            this.comments.Add(comment);

        }



    }
}
