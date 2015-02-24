using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HumanStudentWorker
{
    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The week salary cann't be <0.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.WorkHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The WorkHoursPerDay cann't be <0.");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / (this.workHoursPerDay * 5); //5 working days in a week
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
