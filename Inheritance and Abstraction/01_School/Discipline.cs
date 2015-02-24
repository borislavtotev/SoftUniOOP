using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Discipline: DetailsClass
    {
        private string name;
        private int lectures;
        
        private List<Students> students;

        public Discipline(string name, int lectures, string details = null): this(name, lectures, null, details)
        {
        }

        public Discipline(string name, int lectures, List<Students> students, string details = null)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Students = students;
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("The name of the disclipine cann't be empty");
                }
                this.name = value;
            }
        }

        public int Lectures 
        {
            get
            {
                return this.lectures;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentNullException("Invalid number of lectures.");
                }
                this.lectures = value;
            }
        }

        public List<Students> Students 
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value == null)
                {
                    this.students = new List<Students>();
                }
                else
                {
                    this.students = value;
                }
            }
        }

        public override string ToString()
        {
            string result = "";

            if (this.Details == null)
            {
                result += string.Format("(Name:{0}, Lectures:{1})", this.name, this.lectures);    
            }
            else
            {
                result += string.Format("(Name:{0}, Lectures:{1}, Details:{2})", this.name, this.lectures, this.Details);
            }
            
            return result;
        }
    }
}
