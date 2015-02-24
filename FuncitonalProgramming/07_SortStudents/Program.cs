using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SortStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedStudents =
                from student in _03_ClassStudent.Student.students
                orderby student.FistName descending, student.LastName descending
                select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine();

            var sortedStudents2 = _03_ClassStudent.Student.students.OrderByDescending(student => student.FistName).ThenByDescending(student => student.LastName);

            foreach (var student in sortedStudents2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
