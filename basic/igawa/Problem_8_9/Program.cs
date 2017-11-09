using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 1; i <= 10000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        sum += j;
                    }
                }
                if(i == sum)
                {
                    Console.WriteLine(i + "は完全数");
                }
                sum = 0;
            }
        }
    }
}
