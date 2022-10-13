using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Helper
    {
        SchoolDBEntities context;
        public Helper()
        {
            context = new SchoolDBEntities();
        }
        public List<mark> GetAllMarks()
        {
            return context.marks.ToList();
        }
        public void AddMarks( mark m )
        {
            context.marks.Add( m );
            context.SaveChanges();
        }
        public void DeleteMarks(int RollNo , int SubId)
        {
            var temp = context.marks.ToList().Find(t => t.SubjectId == SubId && t.RollNo == RollNo);
            context.marks.Remove(temp);
            context.SaveChanges();
        }
        public void UpdateMarks(int id, int id1 , mark mark)
        {
            var temp = context.marks.ToList().Find(t => t.SubjectId == id1 && t.RollNo == id);
            context.marks.Remove(temp);
            context.marks.Add(mark);
            context.SaveChanges();
        }
    }
}
