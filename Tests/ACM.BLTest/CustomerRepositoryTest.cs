using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            /* Arrange */
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            /* Act */
            var actual = customerRepository.Retrieve(1);

            /* Assert */
            Assert.AreEqual(expected, actual);
        }
    }
}

/* Arrange */
/* Act */
/* Assert */
