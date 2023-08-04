using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class Array2DAndLoop
    {
        public Array2DAndLoop()
        {
            int[,] arr =
            {
                {1,2,3},
                {4,5,6}                
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                { Console.WriteLine(arr[i, j]); }
            }

        }
    }
}
