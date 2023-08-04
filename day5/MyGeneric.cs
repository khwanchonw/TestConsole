using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day5
{
    class Dog { }

    public class MyGeneric
    {
        public MyGeneric()
        {
            List<Dog> list = new()
            {
                new Dog(),new Dog(),new Dog()
            };

            Console.WriteLine("size of list = {0}",list.Count);

        }
    }
}
