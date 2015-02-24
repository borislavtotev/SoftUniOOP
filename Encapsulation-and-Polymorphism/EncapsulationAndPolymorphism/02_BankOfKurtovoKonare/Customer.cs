using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_BankOfKurtovoKonare
{
    class Customer
    {
        private string name;
        private string type;

        public Customer(string name, string type)
        {
            this.Name = name;
            this.Type = type; 
        }

        public string Name 
        { 
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the customer can't be empty.");
                }

                this.name = value;
            }
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (value != "individual" && value != "company")
                {
                    throw new ArgumentOutOfRangeException("The type of the customer can be 'individual' or 'company' only.");
                }

                this.type = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
