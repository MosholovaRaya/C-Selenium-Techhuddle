using System;
using System.Collections.Generic;
using System.Text;

namespace JiraProject
{
    class Comment
    {
        public TeamMember Author { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
