using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InterestCalculator newLoan = new InterestCalculator(500, 5.6, 10, InterestType.compound);
            Console.WriteLine(newLoan.CalculateInterest());

            InterestCalculator newDeposit = new InterestCalculator(2500, 7.2, 15, InterestType.simple);
            Console.WriteLine(newDeposit.CalculateInterest());
        }
    }
}
