using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L3.Enums;

namespace L3
{
    interface IComputer
    {
        ProcType Proc { get; }
        MnfcrType Mnfcr { get; }
        OSType OS { get; }
        int Frequency { get; }
        int RAM { get; }
        List<string> Soft { get; }
        List<string> Users { get; }
    }
}
