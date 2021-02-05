using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class maxsubsetsum
    {

        public static void Main(string[] args)
        {
            int[] arr = { 10, 14, 16 };
            Console.WriteLine(Maxsubsetsum1(arr));

        }

        private static int Maxsubsetsum1(int[] num)
        {
            int[] res = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                int fsum = 0;

                for (int j = 1; j <= num[i]; j++)
                {
                    if (num[i] % j == 0)
                    {
                        fsum += j;
                    }


                    res[i] = fsum;
                }
            }
            Array.Sort(res);
            return res[res.Length - 1];

        }
    }
}
