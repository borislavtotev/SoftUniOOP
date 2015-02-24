using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_LINQtoExcel
{
    class Student
    {
        public double result;

        public Student(int ID, string firsName, string lastName, string email, string gender, string studentType, 
                        int examResult, int homeworkSent, int homeworkEvaluated, double teamworkScore, 
                        int attendancesCount, double bonus)
        {
            this.ID = ID;
            this.FirstName = firsName;
            this.LastName = lastName;
            this.Email = email;
            this.Gender = gender;
            this.StudentType = studentType;
            this.ExamResult = examResult;
            this.HomeworkSent = homeworkSent;
            this.HomeworkEvaluated = homeworkEvaluated;
            this.TeamworkScope = teamworkScore;
            this.AttendancesCount = attendancesCount;
            this.Bonus = bonus;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string StudentType { get; set; }

        public int ExamResult { get; set; }

        public int HomeworkSent { get; set; }

        public int HomeworkEvaluated { get; set; }

        public double TeamworkScope { get; set; }

        public int AttendancesCount { get; set; }

        public double Bonus { get; set; }

        public void CalculateResult()
        {
            this.result = (this.ExamResult + this.HomeworkSent + this.HomeworkEvaluated + this.TeamworkScope +
                this.AttendancesCount + this.Bonus) / 5;
        }

        public int ID { get; set; }
    }
}
