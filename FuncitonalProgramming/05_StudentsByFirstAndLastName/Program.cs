using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StudentsByFirstAndLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsByFirstAndLastName =
                from student in _03_ClassStudent.Student.students
                where String.Compare(student.FistName,student.LastName) == -1
                select student;

            foreach (var student in studentsByFirstAndLastName)
            {
                Console.WriteLine(student);
            }
        }
    }
}
