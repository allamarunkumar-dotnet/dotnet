using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunConsoleApp
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num = 1238;
            while (num != 0)//123 != 0   12 != 0  1!=0 0 != 0
            {
                int digit = num % 10;//digit = 3 digit = 2 digit = 1
                Console.WriteLine(digit);//3  2 1
                num = num / 10;// num = 12  num = 1 num = 0
            }
        }
    }
}
