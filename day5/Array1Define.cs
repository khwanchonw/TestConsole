using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class Array1Define
    {
        public Array1Define()
        {
            int[] arr = new int[3];

            arr[0] = 9;
            arr[1] = 5;
            arr[2] = 10;
            
            for (int i =0; i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
