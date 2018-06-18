using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProviders
{   //Factory design class
    static class MarketPlace
    {
        private static List<Product> products = new List<Product>();

        private static List<Provider> serviceProviders = new List<Provider>();

        public static Product AddProduct(string itemName, double price, string location)
        {
            var product = new Product
            {
                ItemName = itemName,
                Price = price,
                Location = location,
                ProductNumber = Product.baseProductNumber++
            };
            products.Add(product);
            return product;
        }

        public static Provider AddProvider(string name, ServiceType typeOfService, string city,
            string email, string phoneNumber = "Email only")
        {
            var serviceProvider = new Provider
            {
                Name = name,
                Service = typeOfService,
                City = city,
                Email = email,
                PhoneNumber = phoneNumber
            };
            serviceProviders.Add(serviceProvider);
            return serviceProvider;
        }
    }
}
