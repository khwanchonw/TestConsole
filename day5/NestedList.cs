using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class NestedList
    {
        public NestedList()
        {
            List<List<string>> list = new();
            List<string> myList = new() {"C#","Dev",".NET"};
            list.Add(myList);
            
            foreach (List<string> value in list)
            {
                foreach(string item in value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}


