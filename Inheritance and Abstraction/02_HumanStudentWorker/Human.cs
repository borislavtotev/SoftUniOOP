using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HumanStudentWorker
{
    abstract class Human : IComparable<Human> 
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name cann't be empty");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name cann't be empty");
                }
                this.lastName = value;
            }
        }

        public int CompareTo(Human other)
        {
            if (this.FirstName == other.FirstName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            return this.FirstName.CompareTo(other.FirstName);
        } 
    }
}
