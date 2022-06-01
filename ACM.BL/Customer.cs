using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        /* Default constructor */
        public Customer()
        {
            // Note: Implicit default constructors are defined automatically
            // unless there are overloaded constructors like on this class.
        }

        /* Constructor that allows setting the customer ID*/
        public Customer(int customerID)
        {
            CustomerID = customerID;
        }

        public int CustomerID { get; private set; } // <-- any caller can get the ID, but only this class can set it


        /* Auto implemented property syntax */
        public string FirstName { get; set; }

        /* Full property syntax */
        private string _lastName; // <-- backing field
        public string LastName // <-- "public" is the access modifier
        {
            get
            {
                return _lastName;
            }
            set
            {
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


        public static int InstanceCount { get; set; } // <-- "static" modifier denotes that the member belongs to the class itself, rather than any specific instance


        /// <summary>
        /// Validates customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
