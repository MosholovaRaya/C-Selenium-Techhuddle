using System;
using System.Collections.Generic;
using System.Text;

namespace SmallJiraGroupPracticePart1
{
    class Backlog
    {
        public List<Ticket> Tickets { get; }

        public Backlog()
        {
            Tickets = new List<Ticket>();
        }

    }
}
