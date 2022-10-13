using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    public class StudentController : ApiController
    {
        // GET api/<controller>
        Helper help;
        public StudentController()
        {
            help = new Helper();
        }
        public List<MMark> Get()
        {
            List<MMark> marks = new List<MMark>();
            var ans = help.GetAllMarks();
            foreach (var item in ans)
            {
                marks.Add(new MMark { marks = item.marks, RollNo = item.RollNo, SubjectId = item.SubjectId });
            }
            return marks;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] MMark value)
        {
            mark m = new mark();
            m.SubjectId = value.SubjectId;
            m.RollNo = value.RollNo;
            m.marks = value.marks;
            help.AddMarks(m);
        }

        // PUT api/<controller>/5
        public void Put(int id,int subid, [FromBody] MMark value)
        {
            mark m = new mark();
            m.SubjectId = value.SubjectId;
            m.RollNo = value.RollNo;
            m.marks = value.marks;
            help.UpdateMarks(id, subid, m);
        }

        // DELETE api/<controller>/5
        public void Delete(int RollNo , int SubId )
        {
            help.DeleteMarks( RollNo , SubId );
        }
    }
}