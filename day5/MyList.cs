using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class MyList
    {
        public MyList()
        {
            List<string> list = new() 
                {
                    "Hello",
                    "C#"
                };
            
            Console.Write("\n1. Get Single value at index[0] : ");
            Console.WriteLine(list[0]);

            //1.1. Add Develope to end : ");
            list.Add("Develope");
            
            Console.WriteLine("\n2. Simple list value : ");
            foreach (string l in list)
            {
                Console.WriteLine($"{l}");
            }

            Console.Write("\n3. Use for in single line : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }

            Console.WriteLine("\n\n4. Remove C#");
            list.Remove("C#");

            foreach (string l in list)
            {
                Console.WriteLine($"{l}");
            }

            Console.WriteLine("\n5. Insert More");
            
            list.Insert(1, "PHP");
            
            string[] r = { "Java", "Html" };
            list.InsertRange(2,r);
            
            list.InsertRange(4, new string[] {"C++", "React" });

            foreach (string l in list)
            {
                Console.WriteLine($"{l}");
            }

        }
    }
}
