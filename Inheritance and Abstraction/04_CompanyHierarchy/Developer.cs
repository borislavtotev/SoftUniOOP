using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    class Developer: Employee, IDeveloper
    {
        public Developer(int id, string firtName, string lastName, double salary, string department, List<Project> projects):base(id, firtName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            string results = "";

            foreach (var project in this.Projects)
            {
                results += "(" + project.ToString() + ")";
            }

            return string.Format("Employee type: Developer, {0}, Projects:{1}", base.ToString(), results);
        }
    }
}
