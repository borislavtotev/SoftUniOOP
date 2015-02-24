using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    class Customer: Person, ICustomer
    {
        private  double netPurchaseAmount;
        
        public Customer(int id, string firstName, string lastName, double netPurchaseAmount = 0):base(id,firstName,lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public double NetPurchaseAmount 
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The net purchase amount can't be less than 0.");
                }

                this.netPurchaseAmount = value;
            }
        }
    }
}
