using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAPI.Models
{
    public class MSubject
    {
       

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Duration { get; set; }
        public int ClassNo { get; set; }

       

        public virtual ICollection<MMark> marks { get; set; }
    }
}