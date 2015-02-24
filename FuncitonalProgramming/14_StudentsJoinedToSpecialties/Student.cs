using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public static List<Student> students = new List<Student>()
    {
        new Student("Milena", "Kirova", 26, 215314, "083534523432", "milena.kirova@marketwatch.com", new List<int>(){4,5,6}, 2),
        new Student("Stefan", "Popov", 16, 203114, "+3592424433432", "dcarter1@buzzfeed.com", new List<int>(){2,3,6}, 1),
        new Student("Asya", "Manova", 36, 203314, "002324234523432", "agibson2@house.gov", new List<int>(){3,5,6}, 3),
        new Student("Diana", "Petrova", 23, 203914, "0823464564562", "walexander3@hexun.com", new List<int>(){5,5,5}, 1),
        new Student("Ivan", "Ivanov", 45, 203814, "+359 284563456456", "mhansen4@skype.com", new List<int>(){6,6,6}, 2),
    };

    public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
    {
        this.FistName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
    }

    public string FistName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public int FacultyNumber { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public IList<int> Marks { get; set; }

    public int GroupNumber { get; set; }

    public override string ToString()
    {
        string marks = string.Join(",", this.Marks.ToArray());
        return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", this.FistName, this.LastName, this.Age.ToString(),
            this.FacultyNumber.ToString(), this.Phone, this.Email, marks, this.GroupNumber.ToString());
    }
}

