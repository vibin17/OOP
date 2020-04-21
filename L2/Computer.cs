using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using L2.Enums;

namespace L2
{
    class Computer: IComputer, IOverclock
    {
        private static string[] posSoft = new string[] { "Adobe", "Office", "Drivers", "Opera", "Chrome", "Winrar", "Java" };
        private static string[] posUsers = new string[] { "Dad", "Mom", "John", "Eddie", "Jill", "Ann", "User" };
        public ProcType Proc { get; private set; }
        public MnfcrType Mnfcr { get; private set; }
        public OSType OS { get; private set; }
        public int Frequency { get; private set; }
        public int RAM { get; private set; }
        public List<string> Soft { get; private set; }
        public List<string> Users { get; private set; }
        private bool Overclocked = false;
        public Computer()
        {
            Proc = ProcType.IntelI5;
            Mnfcr = MnfcrType.Hp;
            OS = OSType.Windows;
            Frequency = 3000;
            RAM = 16;
            Soft = new List<string>() { "Office", "Adobe", "Paint" };
            Users = new List<string>() { "User" };
        }
        public Computer(ProcType proc, MnfcrType mnfcr, OSType os, int frequency, int ram, List<string> soft, List<string> users)
        {
            Proc = proc;
            Mnfcr = mnfcr;
            OS = os;
            Frequency = frequency;
            RAM = ram;
            Soft = soft;
            Users = users;
        }
        public bool OverclockTheComputer()
        {
            if (!Overclocked)
            {
                switch (Proc)
                {
                    case ProcType.IntelI5: case ProcType.IntelI7: Frequency += 300; break;
                    case ProcType.IntelI9: Frequency += 500; break;
                    case ProcType.AMDRyzen2600: case ProcType.AMDRyzen3000: Frequency += 500; break;
                    case ProcType.AMDRyzen3600: Frequency += 700; break;
                }
                return true;
            }
            return false;
        }
        public static Computer Generate()
        {
            Random rand = new Random();
            List<String> soft = new List<string>();
            for (int i = 0; i < rand.Next(posSoft.Length); i++)
            {
                string cur = posSoft[rand.Next(posSoft.Length)];
                if (!soft.Contains(cur)) soft.Add(cur);
            }
            List<String> users = new List<string>();
            for (int i = 0; i < rand.Next(posUsers.Length); i++)
            {
                string cur = posUsers[rand.Next(posUsers.Length)];
                if (!users.Contains(cur)) users.Add(cur);
            }
            return new Computer((ProcType)rand.Next(6), (MnfcrType)rand.Next(4), (OSType)rand.Next(4), rand.Next(2000, 4001), rand.Next(4, 25), soft, users);
        }
        public static List<Computer> Generate100()
        {
            List<Computer> computers = new List<Computer>();
            for (int i = 0; i < 100; i++)
            {
                computers.Add(Generate());
                Thread.Sleep(20);
            }
            return computers;
        }
    }
}
