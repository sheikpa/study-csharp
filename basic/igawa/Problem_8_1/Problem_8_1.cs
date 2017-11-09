using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_8_1
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int range = 100;
            for (int i = 1; i <= range; i++)
            {
                for (int j = 1; j <= range; j++)
                {
                    for (int k = 1; k <= range; k++)
                    {
                        if (i * i + j * j == k * k )
                        {
                            Console.Write("{0}*{0}+{1}*{1}={2}*{2} ", i, j, k);
                            cnt += 1;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("1から"+range+"以下の整数の組合せで a*a+b*b=c*c を満たす式は " + cnt + "個");
        }
    }
}
