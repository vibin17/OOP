using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    interface IManufacturer
    {
        string Name { get; }
        string Country { get; }
        int Workers { get; }
    }
}
