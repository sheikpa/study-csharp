using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_11
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 0;
            int max = 0;
            int min = 100;
            for (int i = 1; i <= 5; i++)
            {
                n = rnd.Next(1, 100);
                Console.WriteLine(n);
                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}", min);
        }
    }
}
