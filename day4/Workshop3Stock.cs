using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day4
{
    public class Workshop3Stock
    {
        public Workshop3Stock()
        {
            int totalInStock = 300;
            while (totalInStock > 0)
            {
                Console.WriteLine("\nTotal in stock = {0}",totalInStock);
                Console.Write("Enter qty : ");
                int qty = Convert.ToInt32(Console.ReadLine());

                if (qty > totalInStock) { Console.WriteLine("Over stock!"); }
                else { totalInStock -= qty; }
                
            }
            Console.WriteLine("Out of stock");


        }
    }
}
