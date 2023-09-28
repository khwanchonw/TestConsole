using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class MyReadFile
    {
        public MyReadFile()
        {
            string path = @"D:\AppDev\Training\TestConsole\day6\MyReadFile.cs";

            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }

            FileInfo file = new(path);
            Console.WriteLine(file.IsReadOnly ? "File is read only" : "ready to write");

            List<string> options = new() { "readonly", "not readyonly" };
            Console.WriteLine(file.IsReadOnly ? options[0] : options[1]);

            Console.WriteLine(file.OpenText().ReadToEnd());

         
        }
    }
}
