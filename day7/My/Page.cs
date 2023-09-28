using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day7.My
{
    internal class Page
    {
        public int Id { get; set; }
        public string? TextInPage { get; set; }

        public Page() { }
        public Page(int id,string textInPage) { Id = id; TextInPage = textInPage; }

        public void ReadToString()
        {
            Console.WriteLine(TextInPage);
        }

    }
}
