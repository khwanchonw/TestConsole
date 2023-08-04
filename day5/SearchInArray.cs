using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class SearchInArray
    {
        public SearchInArray() //find 
        {
            string[] arr = { "JAVA", "PHP", "C", "C++", "C#", "Python", "Go" };
            string value = Array.Find(arr,element=> element.Contains('C'))!;
            Console.WriteLine(value + "\n");
            
            string[] values = Array.FindAll(arr, element => element.Contains('C'))!;
            for (int i = 0;i < values.Length; i++)
            {
                Console.WriteLine(values[i]+ "\n");
            }
         
            foreach (string found in values)
            {
                Console.WriteLine(found + "\n");
            }

            int[] indices = Enumerable.Range(0, arr.Length)
                                  .Where(i => arr[i].Contains('C'))
                                  .ToArray();
            foreach (int i in indices)
            {
                Console.WriteLine(i + "\n");
            }

            Console.WriteLine("First 3 ID:");
            int[] first3 = Enumerable.Range(0,3).ToArray();
            foreach (int i in first3)
            {
                Console.WriteLine(first3[i]);
            }

        }
    }
}
