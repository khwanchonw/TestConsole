
namespace TestConsole.day3
{
    public class NestedIf
    {
        public NestedIf()
        {
            int x = 10;

            if (x > 0)
            {
                if (x < 20)
                {
                    Console.WriteLine("x < 20");
                } else
                {
                    Console.WriteLine("x > 20");
                }

            }
            
        }
    }
}

