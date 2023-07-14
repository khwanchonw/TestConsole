using System;
namespace TestConsole.day2
{
    public class Oper2
    {
        public Oper2()
        {
            int x = 10;
            x++;
            Console.WriteLine(x);
            
            x--;
            Console.WriteLine(x);

            x = 10;
            Console.WriteLine(x++);
            x = 10;
            Console.WriteLine(x--);

            x = 10;
            Console.WriteLine(++x);
            x = 10;
            Console.WriteLine(--x);

        }
            
}

}
