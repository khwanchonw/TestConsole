using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.day3;

namespace TestConsole.day4
{
    public class Workshop4Vote
    {
        public  Workshop4Vote()
        {
            int red = 0;
            int orange = 0;
            int blue = 0;
            int bad = 0;
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nVote {0}/{1} : Enter your choice red[1] orange[2] blue[3] : ",i+1,n);
                try
                {
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            red++;
                            break;
                        case 2:
                            orange++;
                            break;
                        case 3:
                            blue++;
                            break;
                        default:
                            bad++;
                            break;
                    }

                }
                catch { Console.WriteLine("Input Error"); }
                Console.WriteLine("Voted red = {0} orange = {1} blue = {2} bad = {3}", red,orange,blue,bad);
            }

            if (red > orange && red > blue)
            { Console.WriteLine("red is winner");}
            else if (orange > red && orange > blue)
            { Console.WriteLine("orange is winner"); }
            else if (blue > red && blue > orange)
            { Console.WriteLine("blue is winner"); }



        }
    }
}
