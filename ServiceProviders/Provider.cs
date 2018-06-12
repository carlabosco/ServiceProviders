using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProviders
{
    enum ServiceType
    {
        Bolos,
        Docinhos,
        Salgados,
        Refeicoes,
        Manicure,
        Estetica,
        Limpeza,
        Babysitting
    }

    class Provider
    {
        private static int baseProviderNumber = 0;

        public string Name { get; set; }
        public ServiceType Service { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int ProviderNumber { get; private set; }


        //Need GUI to finish constructor. 
        public Provider(string name, ServiceType service, string city, string email, string phoneNumber = "Email only")
        {
            ProviderNumber = ++baseProviderNumber;
            Name = name;
            Service = service;
            City = city;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
