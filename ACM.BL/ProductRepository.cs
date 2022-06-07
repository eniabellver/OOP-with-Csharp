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
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
