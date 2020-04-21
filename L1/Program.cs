using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace L1
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.WriteLine("What task do you want to see? (1-3)");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1': Console.WriteLine(); Task1.Task(); break;
                    case '2': Console.WriteLine(); Task2.Task(); break;
                    case '3': Console.WriteLine(); Task3.Task(); break;
                    default: Console.WriteLine(); Console.WriteLine("????"); break;
                }
                Console.WriteLine();
            }
        }
    }
}
