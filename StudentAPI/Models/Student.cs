using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAPI.Models
{
    public  class MStudent
    {
       
      
        public int RollNo { get; set; }
        public string Name { get; set; }
        public System.DateTime DOB { get; set; }
        public int ClassNo { get; set; }

       
        public virtual ICollection<MMark> marks { get; set; }
    }
}