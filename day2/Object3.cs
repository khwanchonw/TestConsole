using System;
namespace TestConsole.day2
{
public class Object3
    {
        public Object3() 
        {
            object obj = new
            {
                info = new
                {
                    name = "khw",
                    age = 46,
                    salary = 120000
                },
                skill = new
                {
                    programming = "C#",
                    db = "MS SQL",
                    os = "Windows",
                    etc = "Labor"
                },
                title = "Info of Noom"
            };
        Console.WriteLine(obj);
        }

        
    }
}
