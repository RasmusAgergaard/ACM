using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //A new object is created to hold the retrived values
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetriveByCustomerId(customerId).ToList();

            //Temp hard coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "email@test.dk";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        /// <summary>
        /// Returns list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
                {
                    //Call an Insert Stored Procedure
                }
                else
                {
                    //Call an Update Stored Procedure
                }
            }
            return success;
        }
    }
}
