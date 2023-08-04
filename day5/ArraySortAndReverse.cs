using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class ArraySortAndReverse
    {
        public ArraySortAndReverse()
        {
            int[] arr = { 1, 3, 9, 7, 2, 5 };
            
            Console.WriteLine("Before");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Reverse");
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("After Sort");
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Reverse After Sort");
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


        }
    }
}
