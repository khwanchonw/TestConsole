using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day4
{
    public class DoWhileLoop
    {
        public  DoWhileLoop()
        {
            int x = 0;
            do {
                Console.WriteLine("x = {0}",x);
                x++;
            } while (x<10);

        }
    }
}
