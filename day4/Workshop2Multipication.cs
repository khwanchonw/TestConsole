using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day4
{
    public class Workshop2Multipication
    {
        public Workshop2Multipication() 
        {
            
            for (int i = 2; i <= 12; i++)
            {

                Console.WriteLine("------{0}------",i);
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine(" {0} x {1} = {2}", i.ToString("00"), j.ToString("00"),i*j);
                }
                Console.WriteLine("\n");
            }
            

        }
    }
}
