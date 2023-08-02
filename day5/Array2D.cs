using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class Array2D
    {
        public Array2D()
        {
            int[,] arr0 = {
            {10,20},
            {30,40},
            {50,60}
            };
            Console.WriteLine("\n===arr0===");
            Console.WriteLine("Array.Length = {0}", arr0.Length);
            Console.WriteLine("Array.Rank = {0}", arr0.Rank);

            for (int i = 0; i < arr0.Length / arr0.Rank; i++)
            {
                for (int j = 0; j < arr0.Rank; j++)
                {
                    Console.WriteLine("{0}", arr0[i, j]);
                }
            }

            //Better way
            int[,] arr1 = new int[3, 2];
            arr1[0, 0] = 10; arr1[0, 1] = 20;
            arr1[1, 0] = 30; arr1[1, 1] = 40;
            arr1[2, 0] = 50; arr1[2, 1] = 60;

            Console.WriteLine("\n===arr0===");
            Console.WriteLine("Array.Length = {0}", arr1.Length);
            Console.WriteLine("Array.Rank = {0}", arr1.Rank);

            for (int i = 0; i < arr1.Length / arr1.Rank; i++)
            {
                for (int j = 0; j < arr1.Rank; j++)
                {
                    Console.Write("[{0},{1}] = {2}\t", i, j, arr1[i, j]);
                }
                Console.WriteLine();
            }
        }
    }


}
