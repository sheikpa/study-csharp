using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_12
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] a = new int[3, 3];
            int m, n;
            for (m = 0; m < 3; m++)
            {
                for (n = 0; n < 3; n++)
                {
                    a[m, n] = rnd.Next(0, 9);
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
        }
    }
}
