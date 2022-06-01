using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem() // <-- default constructor
        {
            
        }

        public OrderItem(int orderItemID) // <-- set ID constructor
        {
            OrderItemID = orderItemID;
        }

        public int OrderItemID { get; private set;}
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }


        /// <summary>
        /// Saves the current OrderItem
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves defined OrderItem data
            return true;
        }

        ///<summary>
        /// Retrieve one OrderItem
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int orderItemID)
        {
            // code that retrieves a defined OrderItem
            return new Product();
        }

        ///<summary>
        /// Retrieve all OrderItems
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            //code that retrieves all products
            return new List<OrderItem>();
        }

        /// <summary>
        /// Validates OrderItem data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductID <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
