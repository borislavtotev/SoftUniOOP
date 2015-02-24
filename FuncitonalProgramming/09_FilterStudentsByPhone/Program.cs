using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_FilterStudentsByPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsByPhone =
                from student in _03_ClassStudent.Student.students
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                select student;

            foreach (var student in studentsByPhone)
            {
                Console.WriteLine(student);
            }
        }
    }
}
