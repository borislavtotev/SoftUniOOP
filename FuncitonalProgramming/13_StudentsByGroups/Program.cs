using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_StudentsByGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsbyGroups =
                from student in Student.students
                group student by student.GroupName into newGroup
                select newGroup;

            foreach (var group in studentsbyGroups)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student);    
                }

                Console.WriteLine();
            }
        }
    }
}
