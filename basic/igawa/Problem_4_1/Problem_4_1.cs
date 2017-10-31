using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_1
    {
        static void Main(string[] args)
        {
            Console.Write("数：");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }
    }
}
