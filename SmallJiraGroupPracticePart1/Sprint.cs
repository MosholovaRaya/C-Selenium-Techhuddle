using System;
using System.Collections.Generic;
using System.Text;

namespace SmallJiraGroupPracticePart1
{
    class Sprint
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Ticket> SprintBacklog {get; }
        

        public Sprint()
        {
            SprintBacklog = new List<Ticket>();
        }

        public double TotalEstimatedTime()
        {
            double sum = 0;
            foreach (Ticket ticket in SprintBacklog)
            {
                sum += ticket.EstimationTime;
            }
            return sum;
        }

        public double TotalCompletionTime()
        {
            double sum = 0;
            foreach (Ticket ticket in SprintBacklog)
            {
                sum += ticket.CompletionTime;
            }
            return sum;
        }
    }
}
