using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BL_Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveExiting()
        {
            //Arrange
            var customerRepository = new CustomerRepository();

            //Creates a new customer, and set the propperties to the same as the one that is hard coded into 
            //the CustomerRepository Retrive method
            var expected = new Customer(1)
            {
                EmailAddress = "email@test.dk",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            //Assert.AreEqual(expected, actual); //This dosent work, as you cant assert to different instances of a object
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetriveExistingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "email@test.dk",
                FirstName = "Ole",
                LastName = "Hansen",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Westroad",
                        StreetLine2 = "205A",
                        City = "Small-town",
                        State = "Small-state",
                        Country = "USA",
                        PostalCode = "445544"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Eastroad",
                        StreetLine2 = "452B",
                        City = "Small-town",
                        State = "Small-state",
                        Country = "USA",
                        PostalCode = "445544"
                    }
                }
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            //More asserts

            //A loop that checks both addresses
        }
    }
}
