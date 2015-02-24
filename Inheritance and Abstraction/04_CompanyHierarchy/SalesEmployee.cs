using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    class SalesEmployee: Employee, ISalesEmployee
    {
        public SalesEmployee(int id, string firtName, string lastName, double salary, string department, List<Sale> sales):base(id, firtName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            string results = "";

            foreach (var sale in this.Sales)
            {
                results += "(" + sale.ToString() + ")";
            }

            return string.Format("Employee type: SalesEmployee, {0}, Sales:{1}", base.ToString(), results);
        }
    }
}
