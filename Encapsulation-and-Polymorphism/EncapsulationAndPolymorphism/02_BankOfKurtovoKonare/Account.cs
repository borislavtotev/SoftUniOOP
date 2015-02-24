using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    abstract class Account
    {
        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        
        public Customer Customer { get; set; }

        public double Balance { get; set; }

        public double InterestRate { get; set; }

        // with this formula A = money * (1 + interest rate * months) we can calculate the end balance after these months, not the interest. T
        // That is the name of the method is CalculateEndBalance not CalculateInterest        
        public virtual double CalculateEndBalance(uint months) 
        {
            return this.Balance * (1 + this.InterestRate * months);
        }

        public void DepositMoney(double money)
        {
            this.Balance += money;
        }
    }
}
