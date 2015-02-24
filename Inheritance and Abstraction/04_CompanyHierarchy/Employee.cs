using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    class Employee: Person, IEmployee
    {
        private string[] departments = new string[]{ "Production", "Accounting", "Sales", "Marketing" };
        private string department;

        public Employee(int id, string firtName, string lastName, double salary, string department):base(id,firtName,lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public double Salary { get; set; }

        public string Department 
        {
            get { return this.department; }
            set
            {
                if (!this.departments.Contains(value))
                {
                    throw new ArgumentException("Inproper department.");
                }

                this.department = value;
            }
        }

        public override string ToString()
        {
            return string.Format("FirstName:{0}, LastName:{1}, Salary:{2}, Department:{3}", this.FirstName, this.LastName, this.Salary, this.Department);
        }


    }
}
