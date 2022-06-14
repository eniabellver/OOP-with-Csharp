using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0) // <-- default constructor
        {

        }

        public Order(int orderID) // <-- constructor to set the ID
        {
            OrderID = orderID;
            OrderItems = new List<OrderItem>();
        }

        public int OrderID { get; private set; }
        public int CustomerID { get; set; }
        public int ShippingAddressID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; } // <-- "DateTimeOffset" tracks date, time and timezone offset, "?" defines a nullable type


        /// <summary>
        /// Validates order data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public string Log() =>
            $"{OrderID}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderID})";
    }
}
