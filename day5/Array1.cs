using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class Array1
    {
        public  Array1()
        {
            int[] myArray = { 3, 7, 9, 11 };
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", myArray[0], myArray[1], myArray[2], myArray[3]);

            for (int i =0; i < myArray.Length;i++)
            {
                Console.WriteLine(myArray[i]);

            }
        }
    }
}
