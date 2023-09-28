using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class MyString
    {
    public MyString()
        {
            string str = "Hello C#";
            Console.WriteLine(str.StartsWith('H'));
            Console.WriteLine(str.StartsWith('h'));
            Console.WriteLine(str.EndsWith('#'));
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Contains("ll"));
            Console.WriteLine(str.IndexOf('e'));
            Console.WriteLine(str.CompareTo("Hello C#"));//-1 = not contain,0= same; 1 = like,
            Console.WriteLine(str == "hello");
            Console.WriteLine(str == "Hello");
            
        }
    }
}
