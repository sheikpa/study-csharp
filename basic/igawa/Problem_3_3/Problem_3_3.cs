using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_3
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);

            if (a < 50)
            {
                Console.WriteLine("50未満です。");
            }
        }
    }
}
