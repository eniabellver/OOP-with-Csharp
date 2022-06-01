using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            /* Arrange */
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 10.50M,
                ProductDescription = "Assorted size set of 4 mini sunflowers",
                ProductName = "Sunflowers"
            };

            /* Act */
            var actual = productRepository.Retrieve(2);

            /* Assert */
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}

/* Arrange */
/* Act */
/* Assert */