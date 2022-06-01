using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Retrieve one customer
    /// </summary>
    public class CustomerRepository
    {
        public Customer Retrieve(int customerID)
        {
            // Create instance of the Customer class
            // Pass in the request ID
            Customer customer = new Customer(customerID);

            // ~Code that retrieves that defined customer~

            // Temporary hard-coded values to return a populated costumer
            if (customerID == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        /// <summary>
        /// Save the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // ~Code that saves the passed customer~

            return true;
        }
    }
}
