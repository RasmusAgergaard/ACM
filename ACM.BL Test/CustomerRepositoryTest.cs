using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

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
    }
}
