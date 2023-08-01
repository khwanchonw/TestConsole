using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day3
{
    public class AppStock
    {
        public  AppStock()
        {
            int totalQtyInStock = 1000;

            Console.Write("Enter your qty : ");
            int qty = Convert.ToInt32(Console.ReadLine());

            if (qty > totalQtyInStock)
            {
                Console.WriteLine("Out of Stock");

            }
            else

            {
                totalQtyInStock-= qty;
                Console.WriteLine("sub stock qty is {0} success \nqty in stock is {1} ", qty,totalQtyInStock);

            }
        }
    }
}
