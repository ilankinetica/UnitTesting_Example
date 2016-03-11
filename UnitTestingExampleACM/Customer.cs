using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingExampleACM
{
    public class Customer
    {
        public Customer()
              : this(0)
        {
        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
            Customer.InstanceCount++;
        }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }
        public static int InstanceCount { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;
            return isValid;
        }
        public string Log()
        {
            var logString = this.CustomerId + ": " +
                this.FullName + " - " +
                "Mail: " + this.EmailAdress + " - ";
            return logString;
        }
    }
}
