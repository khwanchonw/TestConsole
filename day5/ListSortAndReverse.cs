using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class ListSortAndReverse
    {
        public ListSortAndReverse()
        {
            List<int> list = new () {3,5,2,7,4,5,7 };
            foreach (int item in list) Console.Write(item + " ");
            Console.WriteLine();

            //OR
            foreach (int item in new List<int>(list) ) Console.Write(item + " ");
            Console.WriteLine();

            //OR
            Console.Write("List\t : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();

            //Reverse
            list.Reverse();
            Console.Write("Reverse\t : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            //Sort
            list.Sort();
            Console.Write("Sort\t : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
