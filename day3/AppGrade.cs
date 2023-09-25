using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day3
{
    public class AppGrade
    {
        public  AppGrade()
        {
            
            Console.Write("Enter your score : ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score < 50)
            {
                Console.WriteLine("0");
            } else if (score >= 50 && score < 55)
            {
                Console.WriteLine("1");
            }
            else if (score >= 55 && score < 60)
            {
                Console.WriteLine("1.5");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("2");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("3");
            }
            else if (score >= 80)
            {
                Console.WriteLine("4");
            }
            else 
            { 
                Console.WriteLine("data error");
            }
        }
		public static void MyAppGrade()
		{
            Console.Write("Enter score : ");
            string? input = Console.ReadLine();
            bool inputIsInt = int.TryParse(input, out int score);
            if (!inputIsInt) { Console.WriteLine("Score must be number 0 to 100"); }
            else
            {
                string Grade =
                    score > 100 ? "Over Score" :
                    score >= 80 ? "A" :
                    score >= 70 ? "B" :
                    score >= 60 ? "C" :
                    score >= 50 ? "D" :
                    score >= 0 ? "F" :
                    score < 50 ? "F" :
                    "Wrong Score";
                Console.WriteLine(Grade);
            }


        }
		
    }
}
