using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L2.Enums;

namespace L2
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
