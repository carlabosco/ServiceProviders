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
            var provider1 = new Provider("Maria Santos", ServiceType.Bolos, "Isaquah", "maria@gmail.com", "450-999-0000");

            var provider2 = new Provider("Ana Silva", ServiceType.Manicure, "Seattle", "anasilva@gmail.com", "650-999-0000");

            Console.WriteLine($"Name: {provider2.Name}, Provider Number: {provider2.ProviderNumber}");

            var product = MarketPlace.AddProduct("couch", 250, "Issaquah");
        }
    }
}
