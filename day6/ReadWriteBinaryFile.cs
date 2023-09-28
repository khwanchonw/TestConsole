using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.day6
{
    internal class ReadWriteBinaryFile
    {
        public ReadWriteBinaryFile()
        {
            string filename = "DataFsStream.docb";
            string foldername = @"D:\AppDev\Training\TestConsole\day6\";
            string path = Path.Combine(foldername, filename);
            
            //Write
            using (FileStream fsw = new(path, FileMode.Create))
            {
                using BinaryWriter bw = new(fsw);
                bw.Write(123456789);
                bw.Write("teststhing");
                bw.Write(3.41356f);
                bw.Write(true);
            };

            //Read
            using (FileStream fsr = new(path, FileMode.Open))
            {
                using BinaryReader br = new(fsr);
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadSingle());
                Console.WriteLine(br.ReadBoolean());
            };

        }

        
    }
}
