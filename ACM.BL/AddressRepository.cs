using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            //A new object is created to hold the retrived values
            Address address = new Address(addressId);

            //Temp hard coded values to return a populated address
            if (addressId == 1)
            {
                address.StreetLine1 = "Westroad";
                address.StreetLine2 = "182A";
                address.City = "Small-Town";
                address.State = "Shire";
                address.Country = "USA";
                address.PostalCode = "554455";
            }

            return address;
        }

        public IEnumerable<Address> RetriveByCustomerId(int customerId)
        {
            //Code that would retrive the defined addresses for the customer

            //Temp hard coded values to return a set of addresses for a customer
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Westroad",
                StreetLine2 = "205A",
                City = "Small-town",
                State = "Small-state",
                Country = "USA",
                PostalCode = "445544"
            };
            addressList.Add(address); //Add to list

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Eastroad",
                StreetLine2 = "452B",
                City = "Small-town",
                State = "Small-state",
                Country = "USA",
                PostalCode = "445544"
            };
            addressList.Add(address); //Add to list

            return addressList;
        }

        /// <summary>
        /// Saves the current address
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the defined order
            return true;
        }
    }
}
