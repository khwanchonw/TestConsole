
namespace TestConsole.day3
{
    public class If4
    {
        public If4()
        {
            int x = 5;
            int y = 10;

            bool condition1 = (x > 0 && x <= 5);
            bool condition2 = (y == 10 || y > 0);

            if (condition1 && condition2)
            {
                Console.WriteLine("working");
            }

        }
    }
}
