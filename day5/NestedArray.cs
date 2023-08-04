using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class NestedArray
    {
        public NestedArray()
        {
            int[] child1 = { 1, 2, 3 };
            int[] child2 = { 4, 5, 6 };

            int[][] arr1 = { child1,child2};

            Console.WriteLine(arr1[0][0]);
            Console.WriteLine(arr1[1][1]);
            Console.WriteLine();


            for (int i =0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                    Console.WriteLine(arr1[i][j]);
            }


        }
    }
}
