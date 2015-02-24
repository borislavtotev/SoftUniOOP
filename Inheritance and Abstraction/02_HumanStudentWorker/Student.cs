using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_HumanStudentWorker
{
    class Student : Human
    {
        private string faultyNumber;

        public Student(string firstName, string lastName, string faultyNumber)
            : base(firstName, lastName)
        {
            this.FaultyNumber = faultyNumber;
        }

        public string FaultyNumber
        {
            get
            {
                return this.faultyNumber;
            }
            set
            {
                Regex regex = new Regex(@"^[0-9A-za-z]{5,10}$");
                Match match = regex.Match(value);

                if (match.Success)
                {
                    this.faultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Faulty number. It should be with 5-10 digits/letters.");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}",this.FirstName, this.LastName, this.faultyNumber);
        }
    }
}
