using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Teachers: People
    {
        public Teachers(string name, List<Discipline> disciplines, string details = null)
            : base(name, details)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines { get; set; }

        public override string ToString()
        {
            string result = "";

            string disciplinesString = "";

            foreach (var discipline in this.Disciplines)
            {
                disciplinesString += discipline.ToString()+" ";
            }
            
            if (this.Details == null)
            {
                result += string.Format("TeacherName:{0}\nDisciplines:{1}\n", this.Name, disciplinesString);
            }
            else
            {
                result += string.Format("TeacherName:{0}\nDisciplines:{1}\nDetails:{2}\n", this.Name, disciplinesString, this.Details);
            }

            return result;
        }
    }
}
