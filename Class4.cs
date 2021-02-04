using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OjasDotNetEmployee2Batch
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter  number2 : ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;
            int mod = num1 % num2;
            Console.WriteLine("{0}\t{2}\t{3}\t{4}",sum,sub,mul,div,mod);



        }
    }
}
