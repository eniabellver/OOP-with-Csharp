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
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves defined order data
            return true;
        }

        ///<summary>
        /// Retrieve one order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderID)
        {
            // code that retrieves a defined order
            return new Order();
        }

        ///<summary>
        /// Retrieve all orders
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            //code that retrieves all orders
            return new List<Order>();
        }

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
