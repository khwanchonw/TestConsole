using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class StringFormat_Builder
    {
        public StringFormat_Builder() 
        {
            string str = string.Format("Hello {0} may name  is {1}","Bob","KW");
            Console.WriteLine(str);

            StringBuilder stringBuilder = new ();
            for (int i = 0; i < 5; i++)
            {
                stringBuilder.Append($"Line ");
                stringBuilder.Append(string.Format("{0}\n",i+1));

            }
            Console.WriteLine(stringBuilder);
            Console.WriteLine(stringBuilder.Capacity);
            Console.WriteLine(stringBuilder.Length);
            Console.WriteLine(stringBuilder.Remove(7,7));
        }
    }
}
