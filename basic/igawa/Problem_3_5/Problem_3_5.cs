using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_5
{
    class Problem_3_5
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);

            if (30 < a && a <= 70)
            //if (a > 30 && a <= 70)
            {
                Console.WriteLine("30より大きく70以下です。");
            }
        }
    }
}
