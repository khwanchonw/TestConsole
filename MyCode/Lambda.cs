using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.MyCode
{
     class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
    }

    public class LambdaOrderBy
    {
        public LambdaOrderBy()
        {
            List<Person> people = new() {
            new Person { Name = "John",Age = 25 },
            new Person { Name = "Mary",Age = 32 },
            new Person { Name = "Bob",Age = 19 }
            };
            
            Console.WriteLine("Before :");
            foreach (Person item in people) Console.WriteLine("{0} \tAge = {1}", item.Name,item.Age);

            Console.WriteLine("\nAfter Order by age :");
            var OrderByEnum = people.OrderBy(p => p.Age);
            List<Person> sortedByAge = OrderByEnum.ToList();
            foreach (Person item in sortedByAge) Console.WriteLine("{0} \tAge = {1}", item.Name, item.Age);

            //OR
            Console.WriteLine("\nAfter Order by age :");
            foreach (Person item in new List<Person> (people.OrderBy(p => p.Age).ToList())) 
            Console.WriteLine("{0} \tAge = {1}", item.Name, item.Age);

        }
    }
}
