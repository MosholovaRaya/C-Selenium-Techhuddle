using System;
using System.Collections.Generic;
using System.Text;

namespace SmallJiraGroupPracticePart1
{
    class Project
    {
        public string Title { get; set; }
        public List<Ticket> Backlog { get; }
        public Sprint CurrentSprint { get; set; }
        public List<Sprint> PlannedSprints { get; }
        public List<Sprint> CompletedSprints { get; }

        public void CompleteCurrentSprint()
        {
            if (CurrentSprint.EndDate.Date == DateTime.Today)
            {
                foreach (var ticket in CurrentSprint.SprintBacklog)
                {
                    if (ticket.Status!=TicketStatus.Done)
                    {
                        Backlog.Add(ticket);
                        ticket.ChangeStatusToToDo();
                        // The above method won't pass its own validation because of the conditions it has in the Ticket class (for ex. if TicketStatus == BeingTested the ticket cannot go to the Backlog) 
                    }
                } 
            }
        }
        
    }
}
