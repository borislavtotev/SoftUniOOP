using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_StudentsByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsByGroup =
                from student in _03_ClassStudent.Student.students
                where student.GroupNumber == 2
                orderby student.FistName
                select student;

            foreach (var student in studentsByGroup)
            {
                Console.WriteLine(student);
            }
        }
    }
}
