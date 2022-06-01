using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product() // <-- default constructor
        {

        }

        public Product(int productID) // <-- constructor to set the ID
        {
            ProductID = productID;
        }

        public int ProductID { get; private set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; } // <-- the "?" in "decimal?" defines CurrentPrice as a nullable type, it can have a value or be null

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves defined product data
            return true;
        }

        ///<summary>
        /// Retrieve one product
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productID)
        {
            // code that retrieves a defined product
            return new Product();
        }

        ///<summary>
        /// Retrieve all products
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            //code that retrieves all products
            return new List<Product>();
        }

        /// <summary>
        /// Validates product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
