using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_FilterStudentsByEmailDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsByEmail =
                from student in _03_ClassStudent.Student.students
                where student.Email.Contains("@abv")
                select student;

            foreach (var student in studentsByEmail)
            {
                Console.WriteLine(student);
            }
        }
    }
}
