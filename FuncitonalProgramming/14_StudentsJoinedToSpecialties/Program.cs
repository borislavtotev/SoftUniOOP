using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StudentsJoinedToSpecialties
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsWithSpecialties =
                from student in Student.students
                join specialty in StudentSpecialty.studentSpecialties on student.FacultyNumber equals specialty.FacultyNumber
                orderby student.FistName + " " + student.LastName
                select new { name = student.FistName + " " + student.LastName, facultyNumber = student.FacultyNumber, specialty = specialty.SpecialtyName };

            foreach (var student in studentsWithSpecialties)
            {
                Console.WriteLine("{0} {1} {2}", student.name, student.facultyNumber, student.specialty);
            }
        }
    }
}
