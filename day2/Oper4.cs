using System;
namespace TestConsole.day2
{
    public class Oper4
    {
        public Oper4()
        {
            bool a = true;
            bool b = false;
            
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!a);
            Console.WriteLine(!b);

            int x = 5;
            int y = 10;

            Console.WriteLine(x > y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x < y);
            Console.WriteLine(x <= y);
        }

    }

}
