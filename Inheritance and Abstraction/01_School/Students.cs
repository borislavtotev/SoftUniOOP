using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Students: People
    {
        private int classNumber;

        public Students(string name, int classNumber, string details = null): base(name, details)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber 
        {
            get
            {
                return this.classNumber;
            } 

            set
            {
                if (value == 0) //check only whether a student number is valid. We check whether the classnumber is unique when the student is added to a class.
                {
                    throw new ArgumentException("Invalid class number");
                }

                this.classNumber = value; 
            }
        }

        public override string ToString()
        {
            string result = "";

            if (this.Details == null) 
            {
                result+= string.Format("Name:{0}, ClassNumber:{1} \n",this.Name, this.ClassNumber);
            }
            else
            {
                result += string.Format("Name:{0}, ClassNumber:{1}, Details:{2} \n", this.Name, this.ClassNumber, this.Details);
            }

            return result;
        }

    }
}
