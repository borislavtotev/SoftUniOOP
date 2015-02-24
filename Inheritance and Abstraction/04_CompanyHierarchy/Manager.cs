using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    class Manager: Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, double salary, string department, List<Employee> employees):base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            string results = "";

            foreach (var employee in this.Employees)
            {
                results += employee.ToString() + "\n";
            }

            return string.Format("Employee type: Manager, {0}, Employees:\n{1}", base.ToString(), results);
        }
    }
}
