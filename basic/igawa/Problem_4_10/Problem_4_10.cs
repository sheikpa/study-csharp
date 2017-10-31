using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_10
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 0;
            for (int i = 1; i <= 5; i++)
            {
                n = rnd.Next(1, 100);
                Console.WriteLine(n);
            }
        }
    }
}
