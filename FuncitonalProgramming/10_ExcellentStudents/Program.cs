using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExcellentStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var excelentStudents =
                from student in _03_ClassStudent.Student.students
                where student.Marks.Contains(6)
                select new { FullName = student.FistName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in excelentStudents)
            {
                Console.WriteLine("{0} {1}", student.FullName, string.Join(",",student.Marks.ToArray()));
            }
        }
    }
}
