using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StudentsByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsByAge =
                from student in _03_ClassStudent.Student.students
                where student.Age >= 18 && student.Age <= 24
                select new { firstName = student.FistName, lastName = student.LastName, age = student.Age };

            foreach (var student in studentsByAge)
            {
                Console.WriteLine("{0} {1} {2}", student.firstName, student.lastName, student.age);
            }
        }
    }
}
