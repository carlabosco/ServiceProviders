using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProviders
{
    class Product
    {
        public static int baseProductNumber = 0;

        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }
        public int ProductNumber { get; set; }
    }
}
