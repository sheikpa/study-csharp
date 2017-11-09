using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_17
    {
        static void Main(string[] args)
        {
            Console.Write("1から100までの整数値を入力してください。");
            int a = int.Parse(Console.ReadLine());

            if ( a < 1 || 100 < a)
          //if ( a < 1 || a > 100)
            {
                Console.WriteLine("適切な値を入力してください。");
            }
            if (a <= 50)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("50以下の偶数です。");
                }
                else
                {
                    Console.WriteLine("50以下です。");
                }
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("偶数です。");
            }

        }
    }
}
