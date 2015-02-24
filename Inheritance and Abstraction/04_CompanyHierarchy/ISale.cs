using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        double Price { get; set; }
    }
}
