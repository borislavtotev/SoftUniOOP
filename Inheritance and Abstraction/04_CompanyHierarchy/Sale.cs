using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    class Sale: ISale
    {
        private string productName;
        private  double price;

        public Sale(string productName, DateTime date, double price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName 
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the product can't be empty.");
                }

                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public double Price 
        { 
            get { return this.price; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("The price can't be less or equal to 0.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("ProductName:{0} Date:{1} Price:{2}", this.productName, this.Date, this.price);
        }
    }
}
