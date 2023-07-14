using System;
namespace TestConsole.day2
{
    public class Object1
    {
        public Object1() 
        {
            object obj;
            obj = new
            {
                name = "Khwanchon",
                age = 46,
                salary = 150000
            };
            
            Console.WriteLine(obj);
        }
    }
}
