using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_12
{
    class Problem_4_12
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 0;
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= 5; i++)
            {
                n = rnd.Next(1, 100);
                Console.WriteLine(n);
                if (n % 2 == 0)
                {
                    even += 1;
                }
                else
                {
                    odd += 1;
                }
            }
            Console.WriteLine("偶数の数：{0}", even);
            Console.WriteLine("奇数の数：{0}", odd);
        }
    }
}
