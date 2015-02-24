using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    class MortgageAccount: Account
    {
        public MortgageAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }
        
        public override double CalculateEndBalance(uint months)
        {
            if (this.Customer.Type == "individual")
            {
                if (months <= 6)
                {
                    // there is no interest. That is why we return the balance
                    return this.Balance;
                } 
                else
                {
                    return base.CalculateEndBalance(months-6);
                }
            }
            else
            {
                if (months <= 12)
                {
                    return this.Balance * (1 + this.InterestRate /2 * months);
                }
                else
                {
                    return this.Balance * (1 + this.InterestRate / 2 * 12 + this.InterestRate * (months-12));
                }
            }
        }

    }
}
