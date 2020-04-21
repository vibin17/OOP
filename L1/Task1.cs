using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L1
{
    static class Task1
    {
        public static void Task()
        {
            if (File.Exists("MO.txt"))
                File.Delete("MO.txt");
            File.Create("MO.txt").Dispose();
            File.AppendAllText("MO.txt", "Грачев Данила\nКирилл Кияткин\n" +
                "Сабина Досаева\rЕкатерина Рогожина\nХрулев Дмитрий\nДенис Бухалов\n");
            if (File.Exists("MO2.txt"))
                File.Delete("MO2.txt");
            File.Copy("MO.txt", "MO2.txt", false);
        }
    }
}
