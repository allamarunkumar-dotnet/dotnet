using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunConsoleApp
{
    class Class3
    {
        static void Main(string[] args)
        {
            int num = 121;
            int copy = num;
            int rev = 0;
            while (num > 0)//123>0 12>0 1>0
            {
                int digit = num % 10; // digit = 3 digit = 2 digit = 1
                rev = rev * 10 + digit; // rev = 321
                num = num / 10;// num = 12 num = 1 num = 0
            }
            if (copy == rev)
            {
                Console.WriteLine("Given number is palindrome");
            }
            else
            {
                Console.WriteLine("Given number is not a palinrome");
            }


        }
    }
}
