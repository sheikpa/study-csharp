using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_16
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int n=1;n <=9; n++)
                {
                    Console.Write("{0}*{1}={2} ", i, n,i*n);
                }
                Console.WriteLine();
            }
        }
    }
}
