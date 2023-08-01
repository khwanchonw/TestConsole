
namespace TestConsole.day3
{
    public class AppLogin
    {
        public AppLogin()
        {
            string? username;
            string? password;
            Console.Write("Enter Username : ");
            username = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();

            if(username == "admin" || password == "1234")
            {
                Console.WriteLine("Login Success");
            }
            else { Console.WriteLine("Login Fail"); }

        }
    }
}

