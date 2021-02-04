using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OjasDotNetEmployee2Batch
{
    class AssignmentOper
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");



            num1 = num1 + num2;
            
            
            
            Console.WriteLine($"num1 = {num1}");



            num1 += num2;
            Console.WriteLine($"num1 = {num1}");
            num1 -= num2;
            Console.WriteLine($"num1 = {num1}");//30
            num1 *= num2;//600
            Console.WriteLine($"num1 = {num1}");//600
            num1 /= num2;
            Console.WriteLine($"num1 = {num1}");//30

        }
    }
}








