using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order() // <-- default constructor
        {

        }

        public Order(int orderID) // <-- constructor to set the ID
        {
            OrderID = orderID;
        }

        public int OrderID { get; private set; }

        public DateTimeOffset? OrderDate { get; set; } // <-- "DateTimeOffset" tracks date, time and timezone offset, "?" defines a nullable type


        /// <summary>
        /// Validates order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
