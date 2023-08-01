using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day4
{
    public class Workshop5Table8x8
    {
        public Workshop5Table8x8()
        {
            int column = 4;
            int row = 4;
            string box = "[_]";
            string space = "  ";
   
            for (int c = 0; c < column; c++)
            {
                for (int r =0; r < row; r++)
                {
                    Console.Write("{0}{1}",box,space);
                }
                Console.WriteLine();
            }
        }
    }
}
