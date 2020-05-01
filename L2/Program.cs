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
            ComputersTask();
            string str = "English Русский";
            Console.WriteLine();
            Console.WriteLine(str.RusLettersDelete());
        }
        static void ComputersTask()
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
            var lenovoRyzen2600s = computers.Where(x => x.Proc == Enums.ProcType.AMDRyzen2600 && x.Mnfcr == Enums.MnfcrType.Lenovo);
            var dad8Gbs = computers.Where(x => x.RAM == 8 && x.Users.SequenceEqual(new List<string>() { "Dad", "Mom" }));
            var sortProc = computers.OrderBy(x => x.Proc.ToString());
            var sortProcMnfcr = computers.OrderBy(x => x.Proc.ToString()).ThenBy(x => x.Mnfcr.ToString());
            var selFreqRAMSoft = computers.Select(x => new Tuple<int, int, List<string>>(x.Frequency, x.RAM, x.Soft));
            List<Manufacturer> manufacturers = new List<Manufacturer>()
            {
                new Manufacturer("Hp", "USA", 50),
                new Manufacturer("Xiaomi", "China", 2000),
                new Manufacturer("IBM", "USA", 5000),
                new Manufacturer("Lenovo", "China", 2000),
                new Manufacturer("Apple", "USA", 3000)
            };
            var innerJoinDemo = manufacturers.Join(computers, m => m.Name, c => c.Mnfcr.ToString(), (m ,c) => new { Name = m.Name, Country = m.Country, Workers = m.Workers });
            foreach (var demoVar in innerJoinDemo)
                Console.WriteLine($"{demoVar.Name} {demoVar.Country} {demoVar.Workers}");
        }
        static string RusLettersDelete(this string str)
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
