using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    class LoanAccount: Account
    {
        public LoanAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override double CalculateEndBalance(uint months)
        {
            if (this.Customer.Type == "individual")
            {
                return this.CalculateSpecialEndBalance(months, 3);
            } 
            else
            {
                return this.CalculateSpecialEndBalance(months, 2);
            }
        }

        private double CalculateSpecialEndBalance(uint months, uint specialMonths)
        {
            if (months <= specialMonths)
            {
                // there is no interest. That is why we return the balance
                return this.Balance;
            }
            else
            {
                return base.CalculateEndBalance(months - specialMonths);
            }
        }
    }
}
