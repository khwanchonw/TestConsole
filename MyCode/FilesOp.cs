using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.MyCode
{
    public class FilesOp
    {
        public FilesOp()
        {
            string filename = "test.txt";
            string path = "E:\\Temp\\TestFilesOp";
            string abPath = Path.Combine(path,filename);
            string data = "";

            for (int i = 0; i < 5; i++)
            {
                data = data + i + "," + (i * 100 + 451000)+ "," + (i * 50 + 1840000) + "\n";
            }




            Console.WriteLine(this.ToString());

            //StringReader sr = new(data);
            


            File.WriteAllText(abPath, data);


            //List<string> list = new();

            

            



            





             






        }
    }
}
