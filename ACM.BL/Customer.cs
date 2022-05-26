using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        /* Auto implemented property */
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

        public int CustomerID { get; private set; } // <-- Any caller can get the ID, but only this class can set it
    }
}
