using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Simpel_algoritme.tests
{
    [TestClass]
    public class OrderTest
    {
        public void makeOrder(Order order)
        {
            order.products.Add(new Product("pizza", 9.95));
            order.products.Add(new Product("donet", 2.00));
            order.products.Add(new Product("fanta", 0.95));
            order.products.Add(new Product("cola", 0.99));
            order.products.Add(new Product("peren", 1.20));
            order.products.Add(new Product("wijn", 15.00));
            order.products.Add(new Product("brokkoli", 0.89));
        }
        [TestMethod]
        public void MaxPriceTest()
        {
            //arrange
            double expected = 15.00;

            Order order = new Order();
            makeOrder(order);

            //Act
            double actual = order.GiveMaxiumPrice();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void averagePriceTest()
        {
            //arrange
            double expected = 4.43;

            Order order = new Order();
            makeOrder(order);

            //Act
            double actual = order.GiveAveragePrice();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAllProductsTest()
        {
            //Arrange
            List<Product> expected = new List<Product>
            {
                new Product("pizza", 9.95),
                new Product("donet", 2.00),
                new Product("peren", 1.20),
                new Product("wijn", 15.00)
            };

            Order order = new Order();
            makeOrder(order);

            //Act
            List<Product> actual = order.GetAllProducts(1);

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Price, actual[i].Price);
                Assert.AreEqual(expected[i].Name, actual[i].Name);
            }
            
        }

        [TestMethod]
        public void SortProductsByPriceTest()
        {
            //Arrange
            List<Product> expected = new List<Product>
            {
                new Product("wijn", 15.00),
                new Product("pizza", 9.95),
                new Product("donet", 2.00),
                new Product("peren", 1.20),
                new Product("cola", 0.99),
                new Product("fanta", 0.95),
                new Product("brokkoli", 0.89)
            };

            Order order = new Order();
            makeOrder(order);


            //Act
            order.SortProductsByPrice();
            List<Product> actual = order.products;

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Price, actual[i].Price);
                Assert.AreEqual(expected[i].Name, actual[i].Name);
            }
        }
    }
}
