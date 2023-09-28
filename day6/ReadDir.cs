using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class ReadDir
    {
        public ReadDir()
        {
            string path = @"D:\AppDev\Training\TestConsole";

            //method 1
            string[] dirs = Directory.GetDirectories(path);
            foreach (string str in dirs) Console.WriteLine(str);

            Console.WriteLine();

            //method 2
            DirectoryInfo di = new(path);
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                Console.WriteLine(dir.FullName);
            }

            //method 3
            Console.WriteLine("\n Get all file in folder");
            string[] dirss = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (string dir in dirss)
            {
                Console.WriteLine(dir);
            }


            //method 4
            Console.WriteLine("\n Get all file in folder using fileinfo");
            foreach (FileInfo fi in di.GetFiles("*",SearchOption.AllDirectories))
            {
                Console.WriteLine(fi.Name+"\t"+fi.Length);
            }



        }
    }
}
