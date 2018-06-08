using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProviders
{
    class Providers
    {
        private static int basePoviderNumber = 0;

        public string Name { get; set; }
        public string Service { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int ProviderNumber { get; private set; }


        //Need GUI to finish constructor. 
        public Providers()
        {
            ProviderNumber = ++basePoviderNumber;
            Name = Name;
            Service = Service;
            City = City;
            Email = Email;
            PhoneNumber = PhoneNumber;
        }
    }
}
