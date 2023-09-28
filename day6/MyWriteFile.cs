﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class MyWriteFile
    {
        public MyWriteFile()
        {
            string resource = @"D:\AppDev\Training\TestConsole\Resources\";
            string thisfile = @"D:\AppDev\Training\TestConsole\day6\MyWriteFile.cs";
            string output = resource + "test.txt";

            string st = File.ReadAllText(thisfile);
            File.WriteAllText(output,"/*\n" +st+"\n*/");
            Console.WriteLine(File.ReadAllText(resource + "test.txt"));

            File.AppendAllText(output, "\n//Append line1");
            Console.WriteLine(File.ReadAllText(resource + "test.txt"));


            


        }

    }
}
