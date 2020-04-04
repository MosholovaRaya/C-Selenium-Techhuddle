using System;
using System.Collections.Generic;
using System.Text;

namespace JiraProject
{
    class Project
    {
        public string Title;
        public List<Ticket> Backlog;
        public Sprint currentSprint;
        public List<Sprint> completedSprints;
        public List<Sprint> plannedSprints;
        
    }
}
