using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_13
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] a = new int[3, 3];
            int m, n;
            int max = 0;
            int min = 9;
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 3; n++)
                {
                    a[m, n] = rnd.Next(0, 9);
                    if(a[m, n] > max)
                    {
                        max = a[m, n];
                    }
                    if(a[m, n] < min)
                    {
                        min = a[m, n];
                    }
                }
            }
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 3; n++)
                {
                    Console.Write("{0} ", a[m, n]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}", min);
        }
    }
}
