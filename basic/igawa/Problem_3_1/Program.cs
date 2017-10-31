using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_1
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);

            if (a == 3)
            {
                Console.WriteLine("aは3です。");
            }
        }
    }
}
