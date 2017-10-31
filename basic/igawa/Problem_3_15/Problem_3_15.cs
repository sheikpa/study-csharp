using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_15
    {
        static void Main(string[] args)
        {
            Console.Write("a,bに1から100までの数値を入力してください。");
            int a = int.Parse(Console.ReadLine());

            if (a >= 80 && a <=100)
            {
                Console.WriteLine("優");
            }
            else if (a >= 70 && a < 80)
            {
                Console.WriteLine("良");
            }
            else if (a >= 60 && a < 70)
            {
                Console.WriteLine("可");
            }
            else if (a >= 1 && a < 60)
            {
                Console.WriteLine("不可");
            }
            else
            {
                Console.WriteLine("範囲外");
            }
            

        }
    }
}
