using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_3
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.Write("■");
                i++;
            }
            while (i <= a);
            Console.WriteLine();
        }
    }
}
