using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day7
{
    internal class ObjectDog
    {
        public ObjectDog()
        {
            Dog d = new()
            {
                Name = "Test",
                QtyOfLeg = 4,
                Color = "Black"
            };

            Console.WriteLine(d.Name+d.QtyOfLeg+d.Color);
        }
    }
}
