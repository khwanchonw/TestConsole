using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class MyDate
    {
        public MyDate()
        {
            DateTime myDateTime = DateTime.Now;
            myDateTime = new(2023, 12, 29);
            myDateTime = DateTime.Parse("Dec 29, 1977 12:54");
            myDateTime = DateTime.Parse("13/8/2023 13:25");

            Console.WriteLine(myDateTime.Year);
            Console.WriteLine(myDateTime.Month);
            Console.WriteLine(myDateTime.Day);
            Console.WriteLine(myDateTime.Hour);
            Console.WriteLine(myDateTime.Minute);
            Console.WriteLine(myDateTime.Second);


        }

        
    }
}
