using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OjasDotNetEmployee2Batch
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            Console.WriteLine("{0}  {1}   {2}", sum, sub, mul);
            Console.WriteLine($"{sum}  {sub}   {mul}");
        }
    }
}
