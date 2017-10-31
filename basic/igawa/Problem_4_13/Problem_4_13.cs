using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem
{
    class Problem_4_13
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 0;
            n = rnd.Next(1, 10);

            for (int i = 1; i <= n; i++)
            {
                if(n >= 5)
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
