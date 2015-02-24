using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer petya = new Customer("Petya Cocheva", "individual");
            Customer dimitar = new Customer("Dimitar Cochev", "individual");
            Customer zara = new Customer("Zara Cocheva", "individual");
            Customer btk = new Customer("BTK", "company");
            Customer mtel = new Customer("Mtel", "company");
            Customer telenor = new Customer("Telenor", "company");

            DepositAccount petyaDeposit = new DepositAccount(petya, 555, 0.005);
            DepositAccount demitarDeposit = new DepositAccount(dimitar, 2000, 0.0005);

            LoanAccount zaraLoan = new LoanAccount(zara, 100, 0.0001);
            LoanAccount btkLoan = new LoanAccount(btk, 10000, 0.0002);

            MortgageAccount dimitaMortgage = new MortgageAccount(dimitar, 100000, 0.001);
            MortgageAccount telenorMortgage = new MortgageAccount(telenor, 20000000, 0.00012);

            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", petyaDeposit.GetType().Name, petyaDeposit.Customer.ToString(), petyaDeposit.Balance, 12, petyaDeposit.CalculateEndBalance(12));
            petyaDeposit.DepositMoney(500);
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", petyaDeposit.GetType().Name, petyaDeposit.Customer.ToString(), petyaDeposit.Balance, 12, petyaDeposit.CalculateEndBalance(12));
            petyaDeposit.WithdrawMoney(1000);
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", petyaDeposit.GetType().Name, petyaDeposit.Customer.ToString(), petyaDeposit.Balance, 12, petyaDeposit.CalculateEndBalance(12));
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", demitarDeposit.GetType().Name, demitarDeposit.Customer.ToString(), demitarDeposit.Balance, 12, demitarDeposit.CalculateEndBalance(12));
            Console.WriteLine();

            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", zaraLoan.GetType().Name, zaraLoan.Customer.ToString(), zaraLoan.Balance, 3, zaraLoan.CalculateEndBalance(3));
            zaraLoan.DepositMoney(1000);
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", zaraLoan.GetType().Name, zaraLoan.Customer.ToString(), zaraLoan.Balance, 3, zaraLoan.CalculateEndBalance(3));
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", zaraLoan.GetType().Name, zaraLoan.Customer.ToString(), zaraLoan.Balance, 4, zaraLoan.CalculateEndBalance(4));
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", btkLoan.GetType().Name, btkLoan.Customer.ToString(), btkLoan.Balance, 2, btkLoan.CalculateEndBalance(2));
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", btkLoan.GetType().Name, btkLoan.Customer.ToString(), btkLoan.Balance, 3, btkLoan.CalculateEndBalance(3));
            Console.WriteLine();

            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", dimitaMortgage.GetType().Name, dimitaMortgage.Customer.ToString(), dimitaMortgage.Balance, 5, dimitaMortgage.CalculateEndBalance(5));
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", dimitaMortgage.GetType().Name, dimitaMortgage.Customer.ToString(), dimitaMortgage.Balance, 7, dimitaMortgage.CalculateEndBalance(7));
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", telenorMortgage.GetType().Name, telenorMortgage.Customer.ToString(), telenorMortgage.Balance, 12, telenorMortgage.CalculateEndBalance(12));
            Console.WriteLine("{0}, Customer:{1}, Balance:{2}, Term:{3}, EndBalance:{4}", telenorMortgage.GetType().Name, telenorMortgage.Customer.ToString(), telenorMortgage.Balance, 13, telenorMortgage.CalculateEndBalance(13));
        }
    }
}
