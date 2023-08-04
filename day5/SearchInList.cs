using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    public class SearchInList
    {
        public SearchInList()
        {
            List<string> list = new() {"Hello","C#.NET","Dev","Student"};

            Console.Write("\nList all items : ");
            foreach (string  item in list) { Console.Write(item+" "); }

            //Find C
            Console.Write("\nFind C : ");
            string value1 = list.Find(item => item.StartsWith('C'))!;
            Console.Write(value1);

            //FindAll
            Console.Write("\nFindAll e : ");
            List<string> values = list.FindAll(item => item.Contains('n')|| item.Contains('N'))!;

            foreach (string value in values) { Console.Write(value+" "); };

        }
    }
}
