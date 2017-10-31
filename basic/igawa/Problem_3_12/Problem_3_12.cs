using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_3_12
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力:");
            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("負の値です");
            }
            else
            {
                Console.WriteLine("正の値です");
            }

        }
    }
}
