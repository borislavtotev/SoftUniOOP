using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_WeakStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var weakStudents =
                from student in _03_ClassStudent.Student.students
                where student.Marks.ContainThisTimes(2,2) // you can find the method in Extensions.cs
                select new { FullName = student.FistName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in weakStudents)
            {
                Console.WriteLine("{0} {1}", student.FullName, string.Join(",", student.Marks.ToArray()));
            }
        }
    }
}
