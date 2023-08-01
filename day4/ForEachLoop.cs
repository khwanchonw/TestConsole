using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day4
{
    public class ForEachLoop
    {
        public  ForEachLoop()
        {
            string[] sports = {"volley","football","tennis", "swimming","boxing" };
            Array.Sort(sports);
            foreach (string sport in sports) { 
            Console.WriteLine("sport = {0}",sport);

            }

        }
    }
}
