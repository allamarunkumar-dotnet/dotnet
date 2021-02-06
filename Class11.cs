using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunConsoleApp
{
    class Class11
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[2];
            a[2] = new int[5];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Array elements are");
            for (int i = 0; i < a.Length; i++)
            {
                foreach(int k in a[i])
                {
                    Console.Write($"{k}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
