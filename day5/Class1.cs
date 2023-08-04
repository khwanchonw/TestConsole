using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Class1
    {
        public Class1()
        {

        }

        public static void ConsoleArInfo(Array array)
        {
            Console.Write("Array Length = {0}, ", array.Length);
            Console.WriteLine("Dimension = {0}", array.Rank);
            for (int d = 0; d < array.Rank; d++)
            {
                Console.WriteLine("Dimension {0} length = {1}", d, array.GetLength(d));

            }
            Console.WriteLine();
        }
    }


}
