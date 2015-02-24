using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_StudentsJoinedToSpecialties
{
    public class StudentSpecialty
    {
        public static List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>() 
        {
            new StudentSpecialty("Web Developer", 203314),
            new StudentSpecialty("Web Developer", 203114),
            new StudentSpecialty("PHP Developer", 203814),
            new StudentSpecialty("PHP Developer", 203914),
            new StudentSpecialty("QA Engineer", 203314),
            new StudentSpecialty("Web Developer", 203914),
        };
        
        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        public string SpecialtyName { get; set; }

        public int FacultyNumber { get; set; }
    }
}
