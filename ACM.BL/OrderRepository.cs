using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve an order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderID)
        {
            Order order = new Order(orderID);
            // ~Code that retrieves that defined order~

            // Temporary hard-coded values that return a populated order
            if (orderID == 10)
            {
                // Use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// Save the current order
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            // ~Code that saves the current order~

            return true;
        }
    }
}
