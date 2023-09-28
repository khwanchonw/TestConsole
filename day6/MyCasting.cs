using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class MyCasting
    {
        public MyCasting()
        {
            string str = "10";
            
            int a = Convert.ToInt32(str) + 1;
            int b = int.Parse(str) + 2;
            bool _ = int.TryParse(str, out int c); c +=3;
            var d = (double)c + 0.15;
            var e = (int)d;

            Console.WriteLine("a={0} b={1} c={2} d={3} e={4}", a, b, c,d,e);

            string date1 = "29/12/1977";
            DateTime Date1 = Convert.ToDateTime(date1);
            string date2 = "Dec 29, 1977";
            DateTime Date2 = Convert.ToDateTime(date2);
            Console.WriteLine("{0} {1}", Date1, Date2);

            bool bo = 1 + 1 == 2;
            Console.WriteLine(bo);
            Console.WriteLine(bo ? "Yes" : "No");

        }
    }
}
