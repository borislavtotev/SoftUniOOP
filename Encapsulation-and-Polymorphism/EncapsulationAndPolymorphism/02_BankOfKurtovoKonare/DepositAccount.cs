using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    class DepositAccount: Account
    {
        public DepositAccount(Customer customer, double balance, double interestRate): base(customer, balance, interestRate)
        {
        }

        public void WithdrawMoney(double money)
        {
            this.Balance -= money;
        }

        public override double CalculateEndBalance(uint months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                // there is no interest. That is why we return the balance
                return this.Balance;
            } 
            else
            {
                return base.CalculateEndBalance(months);
            }  
        }
    }
}
