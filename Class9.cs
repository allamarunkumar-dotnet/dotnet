using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunConsoleApp
{
    class Class9
    {
        static void Main(string[] args)
        {
            int[,] array = {  {45,67 },  {23,49 },   {56,89 }   };
            for (int i = 0; i <3; i++)//rows i = 3
            {
                for (int j = 0; j < 2; j++)//cols j = 0 j= 1 j=2
                {
                    Console.Write($"{array[i,j]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
