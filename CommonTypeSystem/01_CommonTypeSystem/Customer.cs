using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CommonTypeSystem
{
    class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstName, string middleName, string lastName, long ID, string permanentAddress,
                        string mobilePhone, string email, List<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = ID;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public long ID { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public List<Payment> Payments { get; set; }

        public CustomerType CustomerType { get; set; }

        public string FullName
        {
            get { return this.FirstName + " " + this.MiddleName + " " + this.LastName; }
        }

        public override bool Equals(object obj)
        {
            Customer other = obj as Customer;

            if (other == null)
            {
                return false;
            }

            if (this.ID == other.ID)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder paymentsString = new StringBuilder();
            foreach (var payment in this.Payments)
            {
                paymentsString.Append(payment + " ");
            }

            return string.Format("{0} {1} {2}, {3}, {4}, {5}, {6}, {7}", this.FirstName, this.MiddleName, this.LastName,
                                this.ID, this.PermanentAddress, this.MobilePhone, this.Email, paymentsString, this.CustomerType);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^
                    this.ID.GetHashCode() ^ this.PermanentAddress.GetHashCode() ^ this.MobilePhone.GetHashCode() ^
                    this.Email.GetHashCode() ^ this.Payments.GetHashCode() ^ this.CustomerType.GetHashCode();
        }

        public static bool operator == (Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator != (Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }

        public object Clone()
        {
            List<Payment> payments = new List<Payment>();
            foreach (var payment in this.Payments)
            {
                Payment newPayment = new Payment(payment.ProductName, payment.Price);
                payments.Add(newPayment);
            }
            
            return new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.ID,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                payments,
                this.CustomerType
                );
        }

        public int CompareTo(Customer other)
        {
            int result = this.FullName.CompareTo(other.FullName);
            if (result == 0)
            {
                result = this.ID.CompareTo(other.ID);        
            }

            return result;
        }

        public static bool operator > (Customer customer1, Customer customer2)
        {
            int result = customer1.CompareTo(customer2);
            if (result == 1)
	        {
                return true;		 
	        }
            else
            {
                return false;
            }
        }
        
        public static bool operator < (Customer customer1, Customer customer2)
        {
            int result = customer1.CompareTo(customer2);
            if (result == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
