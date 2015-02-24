using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_StudentsEnrolledIn2014
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentMarks =
                from student in _03_ClassStudent.Student.students
                where student.FacultyNumber.ToString().Substring(4, 2) == "14"
                select student.Marks;

            foreach (var studentMark in studentMarks)
            {
                Console.WriteLine(string.Join(",", studentMark.ToArray()));
            }
        }
    }
}
