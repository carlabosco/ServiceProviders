using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProviders
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider1 = new Providers()
            {
                Name = "Maria Santos",
                Email = "maria@gmail.com",
                PhoneNumber = "450-999-0000",
                City = "Isaquah",
                Service = "Catering"
            };

            var provider2 = new Providers()
            {
                Name = "Ana Silva",
                Email = "anasilva@gmail.com",
                PhoneNumber = "650-999-0000",
                City = "Seattle",
                Service = "Manicure, Pedicure"
            };

            Console.WriteLine($"Name: {provider2.Name}, Provider Number: {provider2.ProviderNumber}");

            var forSale1 = new MarketPlace()
            {
                ItemName = "couch",
                Price = 250,
                Location = "Sammamish"
            };
        }
    }
}
