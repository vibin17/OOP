using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    class Manufacturer : IManufacturer
    {
        public string Name { get; private set; } = "IBM";
        public string Country { get; private set; } = "USA";
        public int Workers { get; private set; } = 5000;
        public Manufacturer() { }
        public Manufacturer(string name, string country, int workers)
        {
            Name = name;
            Country = country;
            Workers = workers;
        }
    }
}
