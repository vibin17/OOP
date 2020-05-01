using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    public class Program
    {
        public delegate double MyDel(int[] a);
        public static MyDel arrAv = (x) =>
        {
            double sum = 0;
            foreach (int numb in x)
                sum += numb;
            return x.Length > 0? sum / x.Length : 0;
        };
        public delegate double MyDel2(int x, int y);
        public static MyDel2 Sum = (x, y) => x + y;
        public static MyDel2 Sub = (x, y) => x - y;
        static void Main()
        {
            while(true)
            {
                switch (Console.ReadLine())
                {
                    case "+":
                        {
                            int x = Convert.ToInt32(Console.ReadLine());
                            int y = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Sum - {Sum(x, y)}");
                            break;
                        }
                    case "-":
                        {
                            int x = Convert.ToInt32(Console.ReadLine());
                            int y = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Sub - {Sub(x, y)}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Wrong input");
                            break;
                        }
                }
            }

        }
    }
}
