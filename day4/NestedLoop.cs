using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day4
{
    public class NestedLoop
    {
        public NestedLoop() 
        { 
            for (int i =0; i < 3;i++)
            {
                for (int j=0;j < 4; j++)
                {
                    Console.WriteLine("i = {0}, j = {1}", i, j);
                }
                Console.WriteLine("---");
            }
        }

    }
}
