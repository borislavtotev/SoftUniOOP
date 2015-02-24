using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Class: DetailsClass
    {
        private string ident;
        private static HashSet<String> identifiers = new HashSet<string>();
        private List<Students> students = new List<Students>();
        private List<int> studentNumbers= new List<int>();
        private List<Teachers> teachers = new List<Teachers>();

        public Class(string ident, string details = null)
        {
            this.Ident = ident;
            this.Details = details;
        }

        public string Ident 
        { 
            get
            {
                return this.ident;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("The ident of the class cann't be empty");
                }

                if (identifiers.Contains(value))
	            {
		            throw new ArgumentException("There is a class already created with this identifier.");    
	            }

                this.ident = value;
                identifiers.Add(value);
            }
        }

        public List<Students> Students 
        {
            get
            {
                return this.students;
            }
        }

        public List<Teachers> Teachers
        {
            get
            {
                return this.teachers;
            }
        }

        public void AddStudent(Students student)
        {
            if (studentNumbers.Contains(student.ClassNumber))
            {
                throw new Exception("There is a student with number " + student.ClassNumber + " in this class " + this.Ident);   
            }

            this.students.Add(student);
            this.studentNumbers.Add(student.ClassNumber);
        }

        public void RemoveStudent(Students student)
        {
            this.students.Remove(student);
            this.studentNumbers.Remove(student.ClassNumber);
        }

        public void AddTeacher(Teachers teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teachers teacher)
        {
            this.teachers.Remove(teacher);
        }

        public override string ToString()
        {
            string result = "";

            result+=this.Ident + " class\n";

            foreach (var student in this.Students)
            {
                result += student.ToString();
            }

            foreach (var teacher in this.Teachers)
            {
                result += teacher.ToString();
            }

            return result;
        }
    }
}
