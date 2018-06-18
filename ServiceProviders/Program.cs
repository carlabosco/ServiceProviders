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
            Console.WriteLine("Provider Registration");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Service: ");
            var typesOfService = Enum.GetNames(typeof(ServiceType));
                for (int i = 0; i < typesOfService.Length; i++)
                {
                    Console.WriteLine($"{i}. {typesOfService[i]}");
                }
            var typeOfService = (ServiceType)Enum.Parse(typeof(ServiceType),Console.ReadLine());

            Console.Write("City: ");
            var city = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Phone number: ");
            var phoneNumber = Console.ReadLine();

            var serviceProvider = MarketPlace.AddProvider(name, typeOfService, city, email, phoneNumber);

            Console.WriteLine($"Name: {serviceProvider.Name}, Email: {serviceProvider.Email}, Service: {serviceProvider.Service}");
            Console.ReadLine();
        }
    }
}
