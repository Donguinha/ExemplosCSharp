using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseControl.Entities
{
    internal class Courses : IComparable
    {
        public int courseorder { get; set; }
        public HashSet<Users> numbers { get; set; } = new HashSet<Users>();

        public Courses(int order, HashSet<Users> studentsnumber)
        {
            courseorder = order;
            numbers = studentsnumber;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Courses))
            {
                throw new ArgumentException("Error, is not a Course");
            }
            Courses course1 = obj as Courses;
            return courseorder.CompareTo(course1.courseorder);
        }        
    }
}
