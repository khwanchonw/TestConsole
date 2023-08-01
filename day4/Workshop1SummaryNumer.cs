using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day4
{
    public class Workshop1SummaryNumer
    {
        public Workshop1SummaryNumer() 
        {
            int sum = 0;
            for (int i = 0; i <= 1000; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum = {0}",sum);

        }
    }
}
