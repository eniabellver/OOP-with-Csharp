using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product() // <-- default constructor
        {

        }

        public Product(int productID) // <-- constructor to set the ID
        {
            ProductID = productID;
        }

        public int ProductID { get; private set; }

        private string _productName;

        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public override string ToString() => ProductName;

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; } // <-- the "?" in "decimal?" defines CurrentPrice as a nullable type, it can have a value or be null

        public string Log() =>
            $"{ProductID}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        /// <summary>
        /// Validates product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
