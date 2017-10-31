using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_16
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力してください。");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                if(a % 3 == 0)
                {
                    Console.WriteLine("2と3の公倍数です。");
                }
                Console.WriteLine("2の倍数です。");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("3の倍数です。");
            }
        }
    }
}
