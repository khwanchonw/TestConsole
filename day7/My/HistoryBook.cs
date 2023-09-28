using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day7.My
{
    internal class HistoryBook : Book,ISchoolBook
    {
        public int Year;
        

        public HistoryBook(int id, string name, List<Page> page,int year) : base(id, name, page)
        {
            Year = year;

        }

        public override void ReadBook()
        {
            Console.WriteLine("Overrided..");
            base.ReadBook();
        }


        new public void CountPages() 
        {
            Console.WriteLine("Page in {0} id {1}",Name,Pages.Count);
        }

        public void Teaching()
        {
            Console.WriteLine("Teaching with {0}", Name);
        }
    }
}
