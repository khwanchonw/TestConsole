using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class MyTime
    {
    public MyTime()
        {
            DateTime d1 = new(2023, 8, 13, 0, 0, 0);
            DateTime d2 = new(2023, 8, 15, 2, 15, 20);
            TimeSpan tp = d2 - d1;
            Console.WriteLine(d1.CompareTo(d2));
            Console.WriteLine(tp.Hours);
            Console.WriteLine(tp.Days);
            Console.WriteLine(tp.Minutes);
            Console.WriteLine(tp.TotalDays);
            Console.WriteLine(tp.TotalHours);
        }
    }
}
