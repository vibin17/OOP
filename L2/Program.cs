using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    static class Program
    {
        static void Main()
        {
            string str = "Eng рус";
            Console.WriteLine(str.RusDelete());
        }
        static void e1()
        {
            List<Computer> computers = Computer.Generate100();
            //foreach (var comp in computers)
            //{
            //    string users = "";
            //    foreach (var user in comp.Users)
            //    {
            //        users += " " + user + "; ";
            //    }
            //    string softs = "";
            //    foreach (var soft in comp.Soft)
            //    {
            //        softs += " " + soft + "; ";
            //    }
            //    Console.WriteLine($"Processor - {comp.Proc.ToString()}, OS - {comp.OS.ToString()}, Manufacturer - {comp.Mnfcr.ToString()}, Frequency - {comp.Frequency}, RAM - {comp.RAM}, Users - [{users}], Soft - [{softs}] ");
            //}
            var i7s = computers.Where(x => x.Proc == Enums.ProcType.IntelI7);
            var lenovo2600 = computers.Where(x => x.Proc == Enums.ProcType.AMDRyzen2600 && x.Mnfcr == Enums.MnfcrType.Lenovo);
            var dad8r = computers.Where(x => x.RAM == 8 && x.Users.SequenceEqual(new List<string>() { "Dad", "Mom" }));
            var sortProc = computers.OrderBy(x => x.Proc);
            var sortProcMnfcr = computers.OrderBy(x => x.Proc).ThenBy(x => x.Mnfcr);
            var selFreq = computers.Select(x => x.Frequency);
            //foreach (var freq in selFreq)
            //    Console.WriteLine(freq);
            var selRam = computers.Select(x => x.RAM);
            var selSoft = computers.Select(x => x.Soft);

            List<Manufacturer> manufacturers = new List<Manufacturer>()
            {
                new Manufacturer("Hp", "USA", 50),
                new Manufacturer("Xiaomi", "China", 2000),
                new Manufacturer("IBM", "USA", 5000),
                new Manufacturer("Lenovo", "China", 2000),
                new Manufacturer("Apple", "USA", 3000)
            };
            var some = manufacturers.Join(computers, m => m.Name, c => c.Mnfcr.ToString(), (m, c) => new { Name = m.Name, Country = m.Country, Workers = m.Workers });
        }
        static string RusDelete(this string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] <= 128) res += str[i];
            }
            return res;
        }
    }
}
