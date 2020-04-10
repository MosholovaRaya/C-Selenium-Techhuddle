using System;
using System.Collections.Generic;
using System.Text;

namespace SmallJiraGroupPracticePart1
{
    class Sprint
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Ticket> Tickets { get; }

        public Sprint()
        {
            Tickets = new List<Ticket>();
        }

    }
}
