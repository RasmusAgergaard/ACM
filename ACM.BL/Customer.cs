using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntiyiBase, ILoggable
    {
        public Customer() 
            : this(0) //Call the other constructor with '0' as parameter
        {

        }

        public Customer(int cutomerId)
        {
            this.CustomerId = cutomerId;
            AddressList = new List<Address>(); //Init the addresslist so that it is empty instead of null
        }

        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }

        public static int InstanceCount { get; set; }

        public int CustomerId { get; private set; }

        public string FirstName { get; set; }

        private string _lastName;

        public string LastName
        {
            get
            {
                //Any code here
                return _lastName;
            }
            set
            {
                //Any code here
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public string EmailAddress { get; set; }

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = this.CustomerId + ": " +
                            this.FullName + " " +
                            "Email: " + this.EmailAddress + " " +
                            "Status: " + this.EntityState.ToString();
            return logString;
        }
    }
}
