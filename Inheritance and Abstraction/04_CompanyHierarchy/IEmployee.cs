using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    interface IEmployee
    {
        double Salary { get; set; }
        string Department { get; set; }
    }
}
