using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace TestConsole.day5
{
    public class Array3D
    {
        public Array3D()
        {
            int[,,] arr =
            {
                {
                    {1,2,3 } ,
                    { 4,5,6}
                },
                {
                    {7,8,9 },
                    {10,11,12 }
                },
            };
            //Class1.ConsoleArInfo(arr); //

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.WriteLine(arr[i, j, k]);
                    }
                }
            }

        }


    }
}
