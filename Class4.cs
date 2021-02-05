using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunConsoleApp
{
    class Class4
    {
        static void Main(string[] args)
        {
            int num = 12;
            int start = 1;
            while (start <= num)
            {
                if (num%start == 0)
                {
                    Console.WriteLine(start);
                }
                start++;
            }
        }
    }
}
