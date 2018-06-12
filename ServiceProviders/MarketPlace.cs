using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProviders
{   //Factory design class
    static class MarketPlace
    {
        public static Product AddProduct(string itemName, double price, string location)
        {
            var product = new Product
            {
                ItemName = itemName,
                Price = price,
                Location = location,
                ProductNumber = Product.baseProductNumber++
            };
            return product;
        }
    }
}
