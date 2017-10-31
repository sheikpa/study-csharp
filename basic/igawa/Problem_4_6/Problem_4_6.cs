using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_6
    {
        static void Main(string[] args)
        {
            int a = 2;
            int i = 1;
            while (i <= 4)
            {
                Console.WriteLine("a = {0}", a*i);
                i++;
            }
            Console.WriteLine();
        }
    }
}
