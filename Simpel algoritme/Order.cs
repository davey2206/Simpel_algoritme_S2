using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_algoritme
{
    public class Order
    {
        public List<Product> products = new List<Product>();
        public double GiveMaxiumPrice()
        {
            double maxPrice = 0;
            foreach (var product in products)
            {
                if (product.Price > maxPrice)
                {
                    maxPrice = product.Price;
                }
            }
            return maxPrice;
        }
        public double GiveAveragePrice()
        {
            double averagePrice = 0;
            foreach (var product in products)
            {
                averagePrice = averagePrice + product.Price;
            }
            averagePrice = averagePrice / products.Count();
            averagePrice = Math.Round(averagePrice, 2);
            return averagePrice;
        }
        public List<Product> GetAllProducts(double minimumPrice)
        {
            List<Product> minProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.Price > minimumPrice)
                {
                    minProducts.Add(product);
                }
            }

            return minProducts;
        }

        public void SortProductsByPrice()
        {
            int n = products.Count;
            for (int i = 1; i < n; ++i)
            {
                Product key = products[i];
                int j = i - 1;

                while (j >= 0 && products[j].Price < key.Price)
                {
                    products[j + 1] = products[j];
                    j = j - 1;
                }
                products[j + 1] = key;
            }
        }
    }
}
