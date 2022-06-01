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
        /// <returns></returns>
        public Address Retrieve(int addressID)
        {
            Address address = new Address(addressID);
            // ~Code that retrieves that defined address~

            // Temporary hard-coded values that return a populated address
            if (addressID == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            // Hard-coded values to return a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };

            return addressList;
        }

        /// <summary>
        /// Save the current address
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            // ~Code that saves the passed address~

            return true;
        }
    }
}
