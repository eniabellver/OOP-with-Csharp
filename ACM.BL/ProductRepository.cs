using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve a product by id
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productID)
        {
            Product product = new Product(productID);
            // ~Code that retrieves that defined product~

            // Temporary hard-coded values that return a populated product
            if (productID == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 mini sunflowers";
                product.CurrentPrice = 10.50M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            // ~Code that saves the current product~

            return true;
        }
    }
}
