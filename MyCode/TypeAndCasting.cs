using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.MyCode
{
    public class TypeAndCasting
    {
        public TypeAndCasting()
        {
            DateTime today = DateTime.Now;
            TimeSpan ts = new(1,0,0,0);
            
            DateTime yesterday = today.Subtract(ts);
            DateTime tomorrow = today.Add(ts);

            Console.WriteLine
                (
                "Today: {0}\nYesterday : {1}\nTomorrow : {2}\n"
                ,today.ToString()
                ,yesterday.ToString()
                ,tomorrow.ToString()
                +
                ""
                );

           string t = Convert.ToString(today);
           DateTime d = DateTime.Parse(t);
        
        }
        
    }
}
