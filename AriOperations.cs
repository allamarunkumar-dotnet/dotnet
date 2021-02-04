using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OjasDotNetEmployee2Batch.Properties
{
    class AriOperations
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter  number2 : ");
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"{num1 + num2}\t{num1 - num2}\t{num1 * num2}\t{num1 / num2}\t{num1 % num2}");

        }
    }
}
