using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InterestCalculator
{
    public class InterestCalculator
    {
        private double money;
        private double years;
        private double interest;
        private InterestType interestType;
        private CalculateInterest calculateInterestDelegate;
        
        public InterestCalculator(double money, double interest, double years, InterestType interestType)
        {
            this.money = money;
            this.interest = interest;
            this.years = years;
            this.InterestType = interestType;
        }

        private InterestType InterestType
        {
            get { return this.interestType; }
            set
            {
                if (value == InterestType.simple)
                {
                    this.calculateInterestDelegate = InterestCalculator.GetSimpleInterest;
                }
                else
                {
                    this.calculateInterestDelegate = InterestCalculator.GetCompountInterest;
                }

                this.interestType = value;
            }
        }

        public double CalculateInterest()
        {
             return calculateInterestDelegate(this.money, this.interest, this.years);
        }

        public static double GetSimpleInterest(double sum, double interest, double years)
        {
            return Math.Round(sum * (1 + interest / 100 * years),4);
        }

        public static double GetCompountInterest(double sum, double interest, double years)
        {
            int n = 12;
            return Math.Round(sum * Math.Pow(1 + interest / 100 /n, years * n),4);
        }
    }
}
