using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_2
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);

            if (a != 4)
            {
                Console.WriteLine("4ではありません。");
            }
        }
    }
}
