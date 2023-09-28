using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day7.My
{
    internal abstract class Book
    {
        public int Id;
        public string? Name;
        public List<Page> Pages;

        public Book(int id,string name,List<Page> page)
        {
            Id = id;Name = name;Pages = page;
        }

        public virtual void ReadBook()
        {
            Console.WriteLine("Book name : {0}",Name);
            foreach(Page p in Pages)
            {
                p.ReadToString();
            }
        }

        public void CountPages()
        {
            Console.WriteLine(Pages.Count);
        }
    }
}
