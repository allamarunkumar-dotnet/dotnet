using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunConsoleApp
{
    class Class14
    {
        static void Main(string[] args)
        {
            int num = 5;
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
            }
        }
    }
}
