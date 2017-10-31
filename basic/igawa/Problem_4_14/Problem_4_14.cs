using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_14
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 0;
            n = rnd.Next(1, 10);

            for (int i = 1; i <= n; i++)
            {
                if (n % 2 == 0)
                {
                    Console.Write("★");
                }
                else
                {
                    Console.Write("☆");
                }
            }
            Console.WriteLine();
        }
    }
}
