using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public static List<Student> students = new List<Student>()
    {
        new Student("Sara", "Mills", 26, 0120143465, "083534523432", "smills0@marketwatch.com", new List<int>(){4,5,6}, 2, "Group A"),
        new Student("Daniel", "Carter", 16, 122015423, "+3592424433432", "dcarter1@buzzfeed.com", new List<int>(){2,3,6}, 1, "Group B"),
        new Student("Aaron", "Gibson", 36, 0120143432, "002324234523432", "agibson2@house.gov", new List<int>(){3,5,6}, 3, "Group C"),
        new Student("William", "Alexander", 23, 1112334, "0823464564562", "walexander3@hexun.com", new List<int>(){5,5,5}, 1, "Group A"),
        new Student("Mildred", "Hansen", 45, 0112323424, "+359 284563456456", "mhansen4@skype.com", new List<int>(){6,6,6}, 2, "Group B"),
        new Student("Antonio", "Gonzalez", 34, 344352243, "+4563456456", "agonzalez5@zdnet.com", new List<int>(){3,4,6}, 3, "Group C"),
        new Student("Cheryl", "Gray", 19, 1220144355, "04564563634", "cgray6@yahoo.com", new List<int>(){2,2,2}, 2, "Group A"),
        new Student("Craig", "King", 21, 2342342, "45634563456", "cking7@cyberchimps.com", new List<int>(){4,4,2}, 2, "Group B"),
        new Student("Craig", "Ellis", 22, 43523435, "08888888", "cellis8@homestead.com", new List<int>(){4,3,2}, 3, "Group C"),
        new Student("Andrea", "Harper", 23, 3420145, "08834345324532", "aharper9@facebook.com", new List<int>(){3,6,6}, 3, "Group A"),
        new Student("Ivan", "Petrov", 27, 324523345, "02453453524532", "ivanpetrov@abv.bg", new List<int>(){2,2,6}, 3, "Group B"),
    };

    public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber, string groupName)
    {
        this.FistName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
        this.GroupName = groupName;
    }

    public string FistName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public int FacultyNumber { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public IList<int> Marks { get; set; }

    public int GroupNumber { get; set; }

    public string GroupName { get; set; }

    public override string ToString()
    {
        string marks = string.Join(",", this.Marks.ToArray());
        return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", this.FistName, this.LastName, this.Age.ToString(),
            this.FacultyNumber.ToString(), this.Phone, this.Email, marks, this.GroupNumber.ToString());
    }
}

