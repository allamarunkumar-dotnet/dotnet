using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunConsoleApp
{
    class DigitCount
    {
        static void Main(string[] args)
        {
            int num = 678;
            int count = 0;
            while (num != 0) //678 != 0 67 !=0 6 != 0 0 != 0
            {
                int digit = num % 10;// digit = 8 digit = 7 digit = 6
                count++;//count = 1 count = 2 count = 3
                num = num / 10;// num = 67 num = 6 num = 0
            }
            Console.WriteLine($"Digit count is {count}");
        }
    }
}
