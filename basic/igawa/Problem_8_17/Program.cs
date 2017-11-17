using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;

            for(int i = 1; i <= 10000; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        sum1 += j;
                    }
                }
                for(int j = 1; j < sum1; j++)
                {
                    if(sum1 % j == 0)
                    {
                        sum2 += j;
                    }
                }
                if (i == sum2 && sum1 < sum2)
                {
                    Console.WriteLine(i + "," + sum1);
                }
                sum1 = 0;
                sum2 = 0;
            }
        }
    }
}
